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
        PlayerPrefs.SetInt("Score", score);
        score++;
        scoreText.text = score.ToString();
    }
}
