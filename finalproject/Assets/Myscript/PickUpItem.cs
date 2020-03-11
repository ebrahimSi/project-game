using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] int NoteNumber=0;
    [SerializeField] GameObject Pickup;
    [SerializeField] GameObject PickupMessage;
    [SerializeField] GameObject PickupDiscription;
    [SerializeField] GameObject Pleyer;
    [SerializeField] Text MassageText;
    [SerializeField] public string ItemDiscription;
    [Tooltip("1 = apple, 2 = battery, 3 = knife, 4 = bat, 5 = axe, 6 = gun, 7 = Note, 8 = key")]
    [SerializeField] int PickupType;

    private bool PickupActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PickupActive = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PickupDiscription.gameObject.SetActive(false);
            MassageText.text="";
            PickupActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PickupActive == true)
        {
            if(SaveScript.CanPickUp == true)
            {
                if(Input.GetKeyDown(KeyCode.E))
                    {
                    PickupMessage.gameObject.SetActive(false);
                    Debug.Log("Picked up:" + PickupType);
                    PickupCheck();
                }else if(Input.GetKeyDown(KeyCode.I)){
                     PickupDiscription.gameObject.SetActive(true);
                   MassageText.text=ItemDiscription;
}
          }
        }
    }

    void PickupCheck()
    {

        if (PickupType == 1)
        {
            SaveScript.PlayerHealth += 10;

            if(SaveScript.PlayerHealth > 100)
            {
                SaveScript.PlayerHealth = 100;
            }
            SaveScript.DisplayHealth = true;
            Destroy(Pickup, 0.2f);

        }



        if (PickupType == 2)
        {
            if(SaveScript.Batteries < 3)
            {

            
            SaveScript.Batteries += 1 ;
            Destroy(Pickup, 0.2f);
            }
        }

        if (PickupType == 3)
        {
            SaveScript.HaveKnife = true;
            Destroy(Pickup, 0.2f);

        }

        if (PickupType == 4)
        {
            SaveScript.HaveBat = true;
            Destroy(Pickup, 0.2f);

        }

        if (PickupType == 5)
        {
            SaveScript.HaveAxe = true;
            Destroy(Pickup, 0.2f);

        }

        if (PickupType == 6)
        {
            SaveScript.HaveGun = true;
            Destroy(Pickup, 0.2f);

        }

        if (PickupType == 7)
        {
            if(NoteNumber==1){
            SaveScript.ReadNote = true;
}else if(NoteNumber==2)
{
 SaveScript.ReadNoteWall = true;
}
         
           

        }
if (PickupType == 8)
        {
            SaveScript.HaveKey = true;
            Destroy(Pickup, 0.2f);

        }
if (PickupType == 9)
        {
            SaveScript.Gass = true;
            Destroy(Pickup, 0.2f);

        }
if (PickupType == 10)
        {
          
            Pleyer.GetComponent<Inventar>()._lpCount += 1;
           Destroy(Pickup, 0.2f);

        }
 
           

 PickupDiscription.gameObject.SetActive(false);
            MassageText.text="";
    }
}
