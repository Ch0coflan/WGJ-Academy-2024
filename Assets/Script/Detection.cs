using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class Detection : MonoBehaviour
    {
        [SerializeField] private string level;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(level);
            }
        }
    }
}