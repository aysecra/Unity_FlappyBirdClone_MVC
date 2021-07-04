using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _score = 0, _highScore;
    private Text _scoreText;

    //refs
    [SerializeField] private Text _panelScore;
    [SerializeField] private Text _panelHighScore;
    [SerializeField] private GameObject _imgNew;

    void Start()
    {
        _score = 0;
        _scoreText = GetComponent<Text>();
        _panelScore.text = _score.ToString();
        _scoreText.text = _score.ToString();

        _highScore = PlayerPrefs.GetInt("highscore");
        _panelHighScore.text = _highScore.ToString();
    }

    public void Scored(){
        _score++;
        _scoreText.text = _score.ToString();
        _panelScore.text = _score.ToString();

        if (_score > _highScore)
        {
            _highScore = _score;
            _panelHighScore.text = _highScore.ToString();
            PlayerPrefs.SetInt("highscore", _highScore);
            _imgNew.SetActive(true);
        }
    }

    public int GetScore()
    {
        return _score;
    }
}
