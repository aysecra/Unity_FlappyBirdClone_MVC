using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class PipeView : MonoBehaviour
    {
        [SerializeField] private GameObject _pipe;
        public GameObject Pipe { get => _pipe; set => _pipe = value; }
        PipeController _controller;

        void Start()
        {
            _controller = new PipeController(this);
        }

        void Update()
        {
            _controller.pipeUpdate();

        }

        public void InstantiatePipe()
        {
            _controller.InstantiatePipe();
        }



    }

}