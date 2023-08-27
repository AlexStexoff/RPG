using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Units.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerControls : MonoBehaviour
    {
        private StatsAssistant _stats;
       
        
        private Rigidbody _rigidbody;      
      

        void Start()
        {
            _stats = new StatsAssistant();
        }

        private void Move()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            Vector3 move = new Vector3(horizontal, 0, vertical);
            transform.Translate(move * _stats.GetMoveSpeed() * Time.deltaTime, Space.Self);
        }
        private void CameraRotation()
        {
            var x = Input.GetAxis("Mouse X");
            transform.Rotate(0, x * _stats.GetCameraSpeed() * Time.deltaTime, 0, Space.World);
        }

       private void FastAttack()
        {
            if(Input.GetMouseButton(0))
            {
                Debug.Log("FastAttack");
            }

        }

        private void StrongAttack()
        {
            if (Input.GetMouseButton(1))
            {
                Debug.Log("StrongAttack");
            }

        }

        void Update()
        {
            Move();
            CameraRotation();
            FastAttack();
            StrongAttack();

        }
    }
}