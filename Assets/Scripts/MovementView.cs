using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class MovementView : MonoBehaviour
    {
        private MovementController _controller;

        void Start()
        {
            _controller = new MovementController(this);

        }

        void Update()
        {
            _controller.movUpdate(this);
        }
    }
}
