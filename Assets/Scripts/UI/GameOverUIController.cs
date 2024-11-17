using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
    [SerializeField] private ScoreUIController _scoreController;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _gameOverUI;

    private void Start() 
    {
        EventsController.Instance.gameOver.AddListener(ActivateGameOver);
    }

    public void ActivateGameOver()
    {
        _gameOverUI.SetActive(true);

        int score = _scoreController.Score;
        _scoreText.text = "Score: " + score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToManu()
    {
        SceneManager.LoadScene("Menu");
    }
}
