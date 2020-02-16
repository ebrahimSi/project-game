using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSound : MonoBehaviour
{
    [SerializeField] GameObject SoundSource;
    [SerializeField] bool SoundLoop = false;

    // Start is called before the first frame update
   void OnTriggerEnter (Collider other)
   {

    if(other.gameObject.CompareTag("Player"))
    {
        SoundSource.gameObject.SetActive(true);

            if (SoundLoop == false)
            {
                Destroy(gameObject, 7);
            }
          
    }
   }
}
