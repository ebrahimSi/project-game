using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    [SerializeField] GameObject flashLight;
   // private bool lightOn = false;
   

    // Update is called once per frame
    void Update()
    {
         if (SaveScript.FlashlightOn == false)
        {
            flashLight.gameObject.SetActive(false);
            SaveScript.FlashlightOn = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
            { 
        if(SaveScript.FlashlightOn == false)
        {
            flashLight.gameObject.SetActive(true);
            SaveScript.FlashlightOn = true;
        }

       else if (SaveScript.FlashlightOn == true)
        {
            flashLight.gameObject.SetActive(false);
            SaveScript.FlashlightOn = false;
        }

    }
    }
}
