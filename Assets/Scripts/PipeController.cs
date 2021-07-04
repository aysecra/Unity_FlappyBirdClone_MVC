using UnityEngine;


namespace MVC
{
    class PipeController
    {
        private PipeView _view;
        private PipeModel _model;

        private PipeController() { }

        public PipeController(PipeView view)
        {
            _view = view;
            _model = new PipeModel();

            _model.Pipe = _view.Pipe;

            if (GameManager.gameOver == false && GameManager.gameHasStarted == true)
                InstantiatePipe();

        }

        public void InstantiatePipe()
        {
            _model.RandY = Random.Range(_model.MinY, _model.MaxY);
            GameObject newPipe = Object.Instantiate(_model.Pipe);
            newPipe.transform.position = new Vector2(_view.transform.position.x, _model.RandY);
        }

        public void pipeUpdate()
        {
            if (GameManager.gameOver == false && GameManager.gameHasStarted == true)
            {
                _model.Timer += Time.deltaTime;
                if (_model.Timer >= _model.MaxTime)
                {
                    InstantiatePipe();
                    _model.Timer = 0;
                }
            }
        }
    }
}
