using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour
{

    [SerializeField] float Distance = 1.0f;
    [SerializeField] LayerMask ignoreLayers;
    [SerializeField] GameObject PickupMessage;
   [SerializeField] GameObject PickupMessageChild;
    RaycastHit hit;

    private Transform Selected;
    private Transform Selection;
  


    // Update is called once per frame
    void Update()
    {
        if(Selection != null)
        {
            PickupMessage.gameObject.SetActive(false);
            PickupMessageChild.gameObject.SetActive(true);
           // PickupDiscription.gameObject.SetActive(false);
            Selection = null;
        }

        if (Selected == null)
        {
            PickupMessage.gameObject.SetActive(false);
            PickupMessageChild.gameObject.SetActive(true);
         //  PickupDiscription.gameObject.SetActive(false);
            SaveScript.CanPickUp = false;
        }

        if(Physics.Raycast(transform.position, transform.forward, out hit, Distance, ~ignoreLayers))
        {
            Selected = hit.transform;
            if(SaveScript.CanShow==true){
            if(hit.transform.tag == "PickUp")
            {
                PickupMessage.gameObject.SetActive(true);
                
                SaveScript.CanPickUp = true;
            }
            if(hit.transform.tag == "NotePicUp")
            {
                PickupMessage.gameObject.SetActive(true);
                PickupMessageChild.gameObject.SetActive(false);
                SaveScript.CanPickUp = true;
            }}

            Selection = Selected;
        }


    }
}
