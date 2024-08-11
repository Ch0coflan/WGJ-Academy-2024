using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleItems : MonoBehaviour
{
    [SerializeField] private int objectsCollected = 0;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            objectsCollected++;
            Destroy(other.gameObject);
            CheckForDoorActivation();
        }
    }

    void CheckForDoorActivation()
    {
        int requiredObjects = 10;

        if(objectsCollected >= requiredObjects)
        {
            ActivateDoor();
        }
    }

    void ActivateDoor()
    {
        Door1.SetActive(true);
        Door2.SetActive(true);
        Door3.SetActive(true);
        Debug.Log("puertas activadas");
    }
}
