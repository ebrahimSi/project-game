using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    [SerializeField] GameObject flashLight;
    [SerializeField] AudioSource AudioflashOn;
    [SerializeField] AudioSource AudioflashOff;
    private bool audiof = false; 

    // private bool lightOn = false;


    // Update is called once per frame
    void Update()
    {
        if(SaveScript.HaveFlashlightOn==true){
         if (SaveScript.FlashlightOn == false)
        {
               // AudioflashOff.Play();

                flashLight.gameObject.SetActive(false);
            SaveScript.FlashlightOn = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
            { 
        if(SaveScript.FlashlightOn == false)
        {
                    AudioflashOn.Play();

                    flashLight.gameObject.SetActive(true);
            SaveScript.FlashlightOn = true;
                   
        }

       else if (SaveScript.FlashlightOn == true)
        {
                   
                        AudioflashOff.Play();
                 
                    flashLight.gameObject.SetActive(false);
            SaveScript.FlashlightOn = false;
                    
                 
        }

    }
    }}
}
