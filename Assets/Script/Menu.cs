using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Script
{
    public class Menu : MonoBehaviour
    {
        [SerializeField] private Animator anim;
        [SerializeField] private GameObject portal;
        [SerializeField] private GameObject button;

        public void Start()
        {
            anim = FindObjectOfType<Animator>();
        }

        public void Play()
        {
            anim.enabled = true;
            portal.SetActive(true);
            StartCoroutine(time());
        }

        IEnumerator time()
        {
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene("Level1");
        }
    }
}