using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    [SerializeField] GameObject flashLight;
    private bool lightOn = false;
   

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.F))
            { 
        if(lightOn == false)
        {
            flashLight.gameObject.SetActive(true);
            lightOn = true;
        }

       else if (lightOn == true)
        {
            flashLight.gameObject.SetActive(false);
            lightOn = false;
        }

    }
    }
}
