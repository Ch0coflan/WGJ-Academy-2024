using Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collectibleItems : MonoBehaviour
{
    [SerializeField] private int objectsCollected = 0;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            objectsCollected++;
            Destroy(other.gameObject);

        }
    }

    

   
}

   

   
