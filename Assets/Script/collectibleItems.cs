using Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collectibleItems : MonoBehaviour
{
    [SerializeField] private int objectsCollected = 0;
    [SerializeField] private int requiredValue = 20;
    public GameObject endObject;
    public Transform spawnObject;
     private Move _move;

    private void Update()
    {
        if(_move != null && _move.timer >= requiredValue)
        {
            SpawnObject();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            objectsCollected++;
            Destroy(other.gameObject);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Fin"))
        {
            SceneManager.LoadScene("lamala");
        }
    }

    private void SpawnObject()
    {
        if (spawnObject != null)
        {
            // Instancia el objeto en la posición y rotación del punto predefinido
            Instantiate(endObject, spawnObject.position, spawnObject.rotation);
            Debug.Log("Objeto instanciado en el punto predefinido.");
        }
        else
        {
            Debug.LogError("No se ha asignado un punto de generación.");
        }
    }

   
}

   

   
