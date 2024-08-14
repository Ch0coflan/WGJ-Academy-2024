using UnityEngine;

public class collectibleItems : MonoBehaviour
{
    [SerializeField] private int _objectsCollected = 0;
    public int objectsCollected
    {
        get
        { return _objectsCollected; }
    }
        

   
    
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            _objectsCollected++;
            Destroy(other.gameObject);

        }
    }

    

   
}

   

   
