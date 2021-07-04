using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MVC
{
    public class BirdView : MonoBehaviour
    {
        private BirdController _controller;


        //refs
        [SerializeField] private Score _score;
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private Sprite _birdDied;
        [SerializeField] private PipeView _pipeView;

        private SpriteRenderer _sr;
        private Rigidbody2D _rb;
        private Animator _anim;

        public Score Score { get => _score; set => _score = value; }
        public GameManager GameManager { get => _gameManager; set => _gameManager = value; }
        public Sprite BirdDied { get => _birdDied; set => _birdDied = value; }
        public PipeView PipeView { get => _pipeView; set => _pipeView = value; }
        public SpriteRenderer Sr { get => _sr; set => _sr = value; }
        public Rigidbody2D Rb { get => _rb; set => _rb = value; }
        public Animator Anim { get => _anim; set => _anim = value; }

        // events
        public UnityAction<Collider2D> onTriggerEnter;
        public UnityAction<Collision2D> onCollisionEnter;

        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _sr = GetComponent<SpriteRenderer>();
            _anim = GetComponent<Animator>();
            _rb.gravityScale = 0;
            _controller = new BirdController(this);
        }


        void Update()
        {
            _controller = new BirdController(this);
            _controller.controlGameStart();
        }
  
        private void OnTriggerEnter2D(Collider2D collision)
        {
            onTriggerEnter?.Invoke(collision);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            onCollisionEnter?.Invoke(collision);
        }
    }
}
