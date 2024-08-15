
using UnityEngine;

namespace Script
{
    public class Level1Manager : MonoBehaviour
    {

        public void Start()
        {
            AudioManager.Instance.PlayNarrator("IntroLevel1");
            AudioManager.Instance.PlayMusic("Puerta3");
        }



    }
}
