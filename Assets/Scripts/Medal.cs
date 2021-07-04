using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class Medal : MonoBehaviour
    {
        [SerializeField] private Sprite _normalMedal;
        [SerializeField] private Sprite _bronzeMedal;
        [SerializeField] private Sprite _silverMedal;
        [SerializeField] private Sprite _goldMedal;


        private Image _img;

        void Start()
        {
            _img = GetComponent<Image>();
            int _gameScore = GameManager.gameScore;

            if (_gameScore > 0 && _gameScore <= 2)
                _img.sprite = _normalMedal;

            else if (_gameScore > 2 && _gameScore <= 4)
                _img.sprite = _bronzeMedal;

            else if (_gameScore > 4 && _gameScore <= 6)
                _img.sprite = _silverMedal;

            else if (_gameScore > 6)
                _img.sprite = _goldMedal;

        }


    }

}