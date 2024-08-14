using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


namespace Script
{
    public class Birthday : MonoBehaviour
    {

        public string narrator;
        public string music;

        public void Start()
        {
            AudioManager.Instance.PlayMusic(narrator);
        }

    }
}