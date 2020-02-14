using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] GameObject Pickup;
    [SerializeField] GameObject PickupMessage;

    [Tooltip("1 = apple, 2 = battery, 3 = knife, 4 = bat, 5 = axe, 6 = gun, 7 = Note")]
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
            SaveScript.ReadNote = true;
            

        }

    }
}
