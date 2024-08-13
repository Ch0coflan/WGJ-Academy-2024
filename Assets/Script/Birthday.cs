using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Script
{
    public class Birthday : MonoBehaviour
    {
        public void Start()
        {
            AudioManager.Instance.PlayMusic("Cuarto");
        }

        public void Door1()
        {
            AudioManager.Instance.ChangeMusic("Cuarto");
            SceneManager.LoadScene("Level1");
        }

        public void Door2()
        {
            AudioManager.Instance.ChangeMusic("Cuarto");
            SceneManager.LoadScene("Level2");
        }

        public void Door3()
        {
            AudioManager.Instance.ChangeMusic("Cuarto");
            SceneManager.LoadScene("Level3");
        }
    }
}