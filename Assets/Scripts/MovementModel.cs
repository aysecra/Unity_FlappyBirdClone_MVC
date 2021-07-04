using UnityEngine;

namespace MVC
{
    class MovementModel
    {
        private float _speed = 0.5f;
        private BoxCollider2D _box;
        private float _groundWidth, _pipeWidth;

        public float Speed { get => _speed; }
        public BoxCollider2D Box { get => _box; set => _box = value; }
        public float GroundWidth { get => _groundWidth; set => _groundWidth = value; }
        public float PipeWidth { get => _pipeWidth; set => _pipeWidth = value; }
    }
}
