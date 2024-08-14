using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


namespace Script
{
    public class Birthday : MonoBehaviour
    {

        public string narratorStart;

        public void Start()
        {
            AudioManager.Instance.PlaySFX(narratorStart);
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                AudioManager.Instance.PlaySFX("NarraIntro02");
            }
        }

    }
}