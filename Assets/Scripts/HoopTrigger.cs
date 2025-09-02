using UnityEngine;

public class HoopTrigger : MonoBehaviour
{

    public bool isCorrectHoop;

    public ScoreTrigger scoreTrigger;


    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "ball"
        if (other.CompareTag("Ball"))
        {
            if (isCorrectHoop)
            {
                scoreTrigger.Hoop_Correct();
            }
            else
            {
                scoreTrigger.Hoop_Wrong();
            }
        }
    }
}
