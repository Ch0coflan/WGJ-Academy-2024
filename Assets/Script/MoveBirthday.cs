using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script
{
    public class MoveBirthday : MonoBehaviour
    {
        [SerializeField] private string horizontal;
        [SerializeField] private string vertical;
        [SerializeField] private Animator anim;
        private float x, y;
        private Rigidbody _rb;
        public float velocidadMove = 5f;
        public float velocidadRote = 200f;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {

            Vector3 forwardMovement = transform.forward * (y * velocidadMove);
            
            _rb.velocity = new Vector3(forwardMovement.x, _rb.velocity.y, forwardMovement.z);
            
            Quaternion deltaRotation = Quaternion.Euler(Vector3.up * (x * velocidadRote * Time.fixedDeltaTime));
            _rb.MoveRotation(_rb.rotation * deltaRotation);
            
            anim.SetFloat("x",x);
            anim.SetFloat("y",y);
            
        }
        void Update()
        {
            x = Input.GetAxis(horizontal);
            y = Input.GetAxis(vertical);


        }
    }
}