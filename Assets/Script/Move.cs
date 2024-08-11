using System;
using UnityEngine;
using Dreamteck.Forever;

namespace Script
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private float jumpForce = 10f;
        private LaneRunner _runner;
        private Rigidbody _rb;
        private void Start()
        {
            _runner = GetComponent<LaneRunner>();
            _rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow)) _runner.lane--;
            if(Input.GetKeyDown(KeyCode.RightArrow)) _runner.lane++;
            if(Input.GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
    }
}