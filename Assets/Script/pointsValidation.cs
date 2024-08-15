using UnityEngine;

public class pointsValidation : MonoBehaviour
{
    public collectibleItems items;
    public GameObject elementoFinal;
    public Transform spawnObject;

    private void Start()
    {
        items = FindObjectOfType<collectibleItems>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(items != null && items.objectsCollected >= 120)
        {
            elementoFinal.SetActive(true);
        }
    }
}
