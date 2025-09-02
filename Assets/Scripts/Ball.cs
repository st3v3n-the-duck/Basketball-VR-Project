using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
    public ScoreTrigger scoreTrigger;

    public AudioSource Disappointment;
    public AudioSource Bouncing;
    public AudioClip FailSoundEffect;
    public AudioClip[] BouncingSoundEffect;
    private Vector3 _initialPosition;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _initialPosition = transform.position;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OutOfBounds"))
        {
            Disappointment.PlayOneShot(FailSoundEffect, 0.3f);
            transform.position = _initialPosition;
            _rigidbody.linearVelocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            scoreTrigger.isValid = false;
            var volumeDependantOnVelocity = Mathf.Clamp01(
                collision.relativeVelocity.magnitude / 20 * 2
            );
            Bouncing.PlayOneShot(
                BouncingSoundEffect[Random.Range(0, BouncingSoundEffect.Length)],
                volumeDependantOnVelocity
            );
        }
    }
}
