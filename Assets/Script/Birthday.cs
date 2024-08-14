using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


namespace Script
{
    public class Birthday : MonoBehaviour
    {
        AudioManager audioManager;

        public void Start()
        {
            audioManager = GetComponent<AudioManager>();
            AudioManager.Instance.PlayMusic("Cuarto");
        }


    }
}