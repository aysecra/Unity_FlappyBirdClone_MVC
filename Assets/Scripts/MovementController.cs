using UnityEngine;

namespace MVC
{
    class MovementController
    {
        private MovementView _view;
        private MovementModel _model;

        private MovementController() { }

        public MovementController(MovementView view)
        {
            _view = view;
            _model = new MovementModel();

            if (_view.gameObject.CompareTag("Ground"))
            {
                _model.Box = _view.GetComponent<BoxCollider2D>();
                _model.GroundWidth = _model.Box.size.x;
            }
            else if (_view.gameObject.CompareTag("Pipes"))
            {
                _model.PipeWidth = GameObject.FindGameObjectWithTag("Pipe").GetComponent<BoxCollider2D>().size.x;
            }

        }

        public void movUpdate(MovementView view)
        {
            if (GameManager.gameOver == false)
                _view.transform.position = new Vector2(_view.transform.position.x - _model.Speed * Time.deltaTime, _view.transform.position.y);

            if (_view.gameObject.CompareTag("Ground"))
            {
                if (_view.transform.position.x <= -_model.GroundWidth)
                    _view.transform.position = new Vector2(_view.transform.position.x + 2 * _model.GroundWidth, _view.transform.position.y);
            }
            else if (_view.gameObject.CompareTag("Pipes"))
            {
                if (_view.transform.position.x < GameManager.bottomLeft.x - _model.PipeWidth)
                {
                    Object.Destroy(_view.gameObject);
                }
            }
        }
    }
}
