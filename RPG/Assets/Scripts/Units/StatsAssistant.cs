using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Units
{
    public class StatsAssistant
    {
        private float _moveSpeed = 10.0f; //todo
        private float _cameraSpeed = 15.0f; //todo

        public float GetMoveSpeed() => _moveSpeed;
        public float GetCameraSpeed() => _cameraSpeed;

    }
      
}
