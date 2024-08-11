using UnityEngine;

namespace Script
{
    public class Camera : MonoBehaviour
    {
        public GameObject player;
 
        void Update()
        {
            transform.position = player.transform.position + new Vector3(-0.74000001f,2.8900001f,-4.53000021f);
        
        }
    }
}