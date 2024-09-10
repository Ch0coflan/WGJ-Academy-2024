using UnityEngine;

public class pointsValidation : MonoBehaviour
{
    private collectibleItems items;
    public GameObject elementoFinal;
    

    private void Start()
    {
        items = FindObjectOfType<collectibleItems>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(items != null && items.objectsCollected >= 2)
        {
            elementoFinal.SetActive(true);
        }
    }
}
