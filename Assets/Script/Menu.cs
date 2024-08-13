using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class Menu : MonoBehaviour
    {
        [SerializeField] private GameObject portal;
        [SerializeField] private GameObject button;
        [SerializeField] private GameObject image;
        [SerializeField] private GameObject ppalMenu; // Referencia al menú principal
        [SerializeField] private GameObject optionsMenu; // Referencia al menú de opciones
        [SerializeField] private GameObject creditsMenu; // Referencia al menú de créditos
        [SerializeField] private GameObject creditsImage; // Referencia a la imagen de créditos

        void Awake()
        {
            optionsMenu.SetActive(false);
            creditsMenu.SetActive(false);
            creditsImage.SetActive(false); // Asegúrate de que la imagen de créditos esté desactivada al inicio
        }

        public void Play()
        {
            Debug.Log("entro");
            portal.SetActive(true);
            Invoke("wait", 1f);
            StartCoroutine(time());
        }

        public void ShowOptions()
        {
            ppalMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }

        public void ShowCredits()
        {
            ppalMenu.SetActive(false);
            creditsMenu.SetActive(true);
            creditsImage.SetActive(true); // Activa la imagen de créditos cuando se muestra el menú de créditos
        }

        public void Back()
        {
            optionsMenu.SetActive(false);
            creditsMenu.SetActive(false); // Asegúrate de desactivar el menú de créditos
            creditsImage.SetActive(false); // Desactiva la imagen de créditos
            ppalMenu.SetActive(true);
        }

        public void ExitGame()
        {
            Application.Quit();
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