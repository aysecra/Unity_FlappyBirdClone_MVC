using UnityEngine;

namespace MVC
{
    class BirdModel
    {
        private Score _score;
        private GameManager _gameManager;
        private Sprite _birdDied;
        private PipeView _pipeView;

        private int _angle, _maxAngle = 20, _minAngle = -90;
        private bool _touchedGround;
        private float _speed = 2;

        private SpriteRenderer _sr;
        private Rigidbody2D _rb;
        private Animator _anim;

        public int Angle { get => _angle; set => _angle = value; }
        public int MaxAngle { get => _maxAngle; }
        public int MinAngle { get => _minAngle;}
        public bool TouchedGround { get => _touchedGround; set => _touchedGround = value; }
        public float Speed { get => _speed; }
        public SpriteRenderer Sr { get => _sr; set => _sr = value; }
        public Rigidbody2D Rb { get => _rb; set => _rb = value; }
        public Animator Anim { get => _anim; set => _anim = value; }
        public Score Score { get => _score; set => _score = value; }
        public GameManager GameManager { get => _gameManager; set => _gameManager = value; }
        public Sprite BirdDied { get => _birdDied; set => _birdDied = value; }
        public PipeView PipeView { get => _pipeView; set => _pipeView = value; }
    }
}
