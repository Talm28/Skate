using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;

    public int Score{get; private set;}

    private void Start() {
        _scoreText = GetComponent<TextMeshProUGUI>();
        EventsController.Instance.scoreCollected.AddListener(AddScore);

        Score = 0;
        UpdateScoreText();
    }

    public void AddScore()
    {
        Score += 1;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        _scoreText.text = Score.ToString();
    }
}
