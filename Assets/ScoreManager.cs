using UnityEngine;
using TMPro; // Penting untuk TextMeshPro

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI leftScoreText;
    [SerializeField] private TextMeshProUGUI rightScoreText;

    [SerializeField] private int maxScore = 11;
    private int leftScore = 0;
    private int rightScore = 0;

    public void AddLeftScore()
    {
        leftScore++;
        leftScoreText.text = leftScore.ToString();
    }

    public void AddRightScore()
    {
        rightScore++;
        rightScoreText.text = rightScore.ToString();
    }
}