using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;

    private void Awake()
    {
        Instance = this;
    }

    public void ScorePlus()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
