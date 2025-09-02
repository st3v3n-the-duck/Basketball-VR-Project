using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TMP_Text Score1;

    public TMP_Text Score2;

    private void Awake()
    {
        Score1.text = "0";
        Score2.text = "0";
    }

    public void ScoreUpdate(int hoop, int score)
    {
        switch (hoop)
        {
            case 1:
                Score1.text = score.ToString();
                break;

            case 2:
                Score2.text = score.ToString();
                break;
        }
    }
}
