using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLamp : MonoBehaviour
{
    [SerializeField] GameObject LightOnOf;
    [SerializeField] AudioSource LightOnOfSound;
    [SerializeField] GameObject SwitchOn;
    [SerializeField] GameObject SwitchOff;
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
                    SwitchOn.gameObject.SetActive(true);
                    SwitchOff.gameObject.SetActive(false);

                }
                else { LightOnOf.gameObject.SetActive(true);
                    Material mymat = GetComponent<Renderer>().material;
                    mymat.EnableKeyword("_Emission");
                    LightOnOfSound.Play();
                    SwitchOff.gameObject.SetActive(true);
                    SwitchOn.gameObject.SetActive(false);
                }

            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTrigger = true;
            if (LightOnOf.gameObject.activeSelf)
            {
                SwitchOff.gameObject.SetActive(true);
                SwitchOn.gameObject.SetActive(false);
            }
            else
            {
                SwitchOn.gameObject.SetActive(true);
                SwitchOff.gameObject.SetActive(false);
            }

        }
    }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                isTrigger = false;
          
            SwitchOn.gameObject.SetActive(false); 
            SwitchOff.gameObject.SetActive(false);
        }


        }
    
}
