using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLamp : MonoBehaviour
{
    [SerializeField] GameObject LightOnOf;
    [SerializeField] AudioSource LightOnOfSound;
    private bool isTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (LightOnOf.gameObject.activeSelf)
                {
                    LightOnOf.gameObject.SetActive(false);
                    LightOnOfSound.Play();
                }
                else { LightOnOf.gameObject.SetActive(true);
                    LightOnOfSound.Play();
                }

            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTrigger = true;
           
        }
    }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                isTrigger = false;
         
            }


        }
    
}
