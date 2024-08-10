using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script
{
    public class MovePlayer : MonoBehaviour
    {
        [SerializeField] private String horizontal;
        [SerializeField] private float speed;
        [SerializeField] private float speedFront;
        [SerializeField] private float timer;
        private float _incrementTime = 30f,_speedIncrement = 5f;
       
        private Rigidbody _rb;
        private float _x;


        private void Start()
        {
            
            _rb = GetComponent<Rigidbody>();
            timer = 0f;
        }

        private void FixedUpdate()
        {
            // se hace timer para que despues de 30 segundos la velocidad frontal incremente de a 5 
            timer += Time.fixedDeltaTime;

            if (timer >= _incrementTime)
            {
                speedFront += _speedIncrement;
                timer = 0f;
            }
            
            _x = Input.GetAxis(horizontal);
            
            // vector de velocidad hacia adelante
            Vector3 forward = transform.forward * speedFront;
            Vector3 lateral = new Vector3(_x, 0f, 0f) * speed;
            
            // se hace esto para que el salto se vea mejor, puesto que la velocidad vertical de y cambiaba
            Vector3 newVelocity = forward + lateral;
            newVelocity.y = _rb.velocity.y; // Mantén la velocidad vertical actual
     
            _rb.velocity = newVelocity;
        }
    }
}