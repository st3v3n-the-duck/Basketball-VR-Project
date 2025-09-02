using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public int HoopNumber;

    public ScoreDisplay scoreDisplay;

    public AudioSource SuccessfulScore;
    public AudioClip SuccessfulSoundEffect;

    [SerializeField] private int Score = 0;


    public bool isValid = true;

    public PlayerPosition playerPosition;


    private void Awake()
    {
        scoreDisplay = FindAnyObjectByType<ScoreDisplay>();

    }

    public void Hoop_Correct()
    {
        isValid = true;
    }

    public void Hoop_Wrong()
    {
        if (isValid)
        {
            AddPoint();
            isValid = false;
        }
    }

    private void AddPoint()
    {
        Score+=playerPosition.Zone;
        scoreDisplay.ScoreUpdate(HoopNumber, Score);
        SuccessfulScore.PlayOneShot(SuccessfulSoundEffect);
    }
}



