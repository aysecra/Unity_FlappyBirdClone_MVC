using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MVC
{
    public class GameManager : MonoBehaviour
    {
        //refs
        [SerializeField] private GameObject canvasGameOver;
        [SerializeField] private GameObject score;
        [SerializeField] private GameObject ImgGetReady;
        [SerializeField] private GameObject btnPause;

        public static Vector2 bottomLeft;

        //states
        public static bool gameOver, gameHasStarted, gameIsPaused;

        public Text panelScore;

        public static int gameScore;
        int drawScore;

        void Start()
        {
            gameOver = false;
            gameHasStarted = false;
            gameIsPaused = false;
        }

        void Awake()
        {
            bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        }

        public void GameHasStarted()
        {
            gameHasStarted = true;
            score.SetActive(true);
            ImgGetReady.SetActive(false);
            btnPause.SetActive(true);
        }

        public void GameOver()
        {
            gameOver = true;
            gameScore = score.GetComponent<Score>().GetScore();
            score.SetActive(false);
            Invoke("ActivateCanvasGameOver", 1);
        }

        void ActivateCanvasGameOver()
        {
            canvasGameOver.SetActive(true);
        }

        public void OnBtnOkClicked()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void DrawScore()
        {
            if (drawScore <= gameScore)
            {
                panelScore.text = drawScore.ToString();
                drawScore++;
                Invoke("DrawScore", 0.05f);
            }
        }

    }
}
