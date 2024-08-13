using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Script
{
    public class Birthday : MonoBehaviour
    {
        
        public void Door1()
        {
            SceneManager.LoadScene("Level1");
        }
        public  void Door2()
        {
            SceneManager.LoadScene("Level2");
        }
        public  void Door3()
        {
            SceneManager.LoadScene("Level3");
        }
    }
}