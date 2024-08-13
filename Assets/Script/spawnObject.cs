using Dreamteck.Forever;
using Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnObject : MonoBehaviour
{
    [SerializeField] private int requiredValue = 20;
    public float timer;
    public GameObject endObject;
    public Transform _spawnObject;
    private GameObject _instantiatedObject;
  

    private void Update()
    {

        timer += Time.fixedDeltaTime;

        if ( timer >= requiredValue)
        {
            SpawnObject();
            Debug.Log("Se ha instanciado el objeto final");
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fin"))
        {
            SceneManager.LoadScene("lamala");
        }
    }

    private void SpawnObject()
    {
        if (_spawnObject != null)
        { 
            // Instancia el objeto en la posición y rotación del punto predefinido
            _instantiatedObject = Instantiate(endObject, _spawnObject.position, _spawnObject.rotation);
            Debug.Log("Objeto instanciado en el punto predefinido.");

            Invoke("DestroyInstantiatedObject", 5f);
            timer = 0f;
        }
        else
        {
            Debug.LogError("No se ha asignado un punto de generación.");
        }
    }

    private void DestroyInstantiatedObject()
    {
        if(_instantiatedObject != null)
        {
            Destroy(_instantiatedObject);
            Debug.Log("Objeto destruido");
        }
        
    }
}
