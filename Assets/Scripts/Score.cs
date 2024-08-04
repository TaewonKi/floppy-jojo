using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Start ()
    {
        _currentScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    public void UpdateHighScore ()
    {
        _score++;
        _currentScoreText.text = _score.ToString()
        UpdateHighScore();
    }
}
