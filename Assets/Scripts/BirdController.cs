using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MVC
{
    class BirdController 
    {
        private BirdView _view;
        private BirdModel _model;

        private BirdController() { }

        public BirdController(BirdView view)
        {
            _view = view;
            _model = new BirdModel();

            
            _model.Score = _view.Score;
            _model.GameManager = _view.GameManager;
            _model.BirdDied = _view.BirdDied;

            _model.PipeView = _view.PipeView;
            _model.Sr = _view.Sr;
            _model.Rb = _view.Rb;
            _model.Anim = _view.Anim;

            //controlGameStart();
            //BirdRotation();

            _view.onTriggerEnter = TriggerEntered;
            _view.onCollisionEnter = CollisionEntered;


        }

        void TriggerEntered(Collider2D collision)
        {
            //Debug.Log("Controller TriggerEntered");
            if (collision.CompareTag("Pipes"))
            {
                _model.Score.Scored();
            }
            else if (collision.CompareTag("Pipe"))
            {
                _model.GameManager.GameOver();
            }
        }

        void CollisionEntered(Collision2D collision)
        {
            //Debug.Log("Controller CollisionEntered");
            if (collision.gameObject.CompareTag("Ground"))
            {
                if (GameManager.gameOver == false)
                {
                    _model.GameManager.GameOver();
                }

            }
            GameOver();
        }

        public void controlGameStart()
        {
            if (Input.GetMouseButtonDown(0) && GameManager.gameOver == false && GameManager.gameIsPaused == false)
            {
                if (GameManager.gameHasStarted == false)
                {
                    _model.Rb.gravityScale = 0.8f;
                    _model.GameManager.GameHasStarted();
                }
                Flap();
            }
            BirdRotation();
        }

        void BirdRotation()
        {
            if (_model.Rb.velocity.y > 0)
            {
                _model.Rb.gravityScale = 0.8f;

                if (_model.Angle <= _model.MaxAngle)
                    _model.Angle += 4;
            }
            else if (_model.Rb.velocity.y < 0f)
            {
                _model.Rb.gravityScale = 0.6f;

                if (_model.Rb.velocity.y < -1.3f)
                    if (_model.Angle >= _model.MinAngle)
                        _model.Angle -= 3;
            }

            if (_model.TouchedGround == false)
            {
                _view.transform.rotation = Quaternion.Euler(0, 0, _model.Angle);
            }
        }
        void GameOver()
        {
            _model.TouchedGround = true;
            _model.Anim.enabled = false;
            _model.Sr.sprite = _model.BirdDied;
            _view.transform.rotation = Quaternion.Euler(0, 0, -90);
        }

        void Flap()
        {

            _model.Rb.velocity = Vector2.zero;
            _model.Rb.velocity = new Vector2(_model.Rb.velocity.x, _model.Speed);
        }

        public void OnGetReadyAnimFinished()
        {
            _model.PipeView.InstantiatePipe();
            _model.GameManager.GameHasStarted();

        }




    }
}
