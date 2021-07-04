using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class Pause : MonoBehaviour
    {
        private Image _img;

        //refs
        [SerializeField] private Sprite _playSprite;
        [SerializeField] private Sprite _pausedSprite;

        private void Start()
        {
            _img = GetComponent<Image>();
        }

        public void OnPauseGame()
        {
            if (GameManager.gameIsPaused == false)
            {
                Time.timeScale = 0;
                _img.sprite = _playSprite;
                GameManager.gameIsPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                _img.sprite = _pausedSprite;
                GameManager.gameIsPaused = false;
            }
        }

    }

}