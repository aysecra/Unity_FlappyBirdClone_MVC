using UnityEngine;


namespace MVC
{
    class PipeModel
    {
        private GameObject _pipe;
        float maxY = 0.6f, minY = -0.2f, randY, maxTime = 1.5f, timer;

        public GameObject Pipe { get => _pipe; set => _pipe = value; }
        public float MaxY { get => maxY; }
        public float MinY { get => minY;}
        public float RandY { get => randY; set => randY = value; }
        public float MaxTime { get => maxTime;}
        public float Timer { get => timer; set => timer = value; }
    }
}
