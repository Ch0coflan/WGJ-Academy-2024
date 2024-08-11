using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class doorTrigger : MonoBehaviour
{
    [SerializeField] public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            teleportPlayerTo(other.gameObject);
        }
    }

    private void teleportPlayerTo(GameObject player)
    {
        if(teleportPoint!= null)
        {
            player.transform.position = teleportPoint.transform.position;
            player.transform.position = teleportPoint.transform.position;
        }
        else
        {
            Debug.LogWarning("no hay punto asignado");
        }
    }




}
