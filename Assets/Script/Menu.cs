using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Script
{
    public class Menu : MonoBehaviour
    {
       // [SerializeField] private Animator anim;
        [SerializeField] private GameObject portal;
        [SerializeField] private GameObject button;
        [SerializeField] private GameObject image;



        public void Play()
        {
            Debug.Log("entro");
            portal.SetActive(true);
            Invoke("wait",1f);
            StartCoroutine(time());
        }

        public void Level1()
        {
            SceneManager.LoadScene("Level1");
        }

        IEnumerator time()
        {
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene("Birthday");
        }

        private void wait()
        {
            image.SetActive(false);
        }
    }
}