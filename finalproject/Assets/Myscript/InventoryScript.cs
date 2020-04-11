using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    // visible in inspector
    [SerializeField] GameObject InventoryMenu;
    [SerializeField] GameObject KnifeImage;
    [SerializeField] GameObject KnifeButton;
    [SerializeField] GameObject BatImage;
    [SerializeField] GameObject BatButton;
    [SerializeField] GameObject AxeImage;
    [SerializeField] GameObject AxeButton;
    [SerializeField] GameObject GunImage;
    [SerializeField] GameObject GunButton;
    [SerializeField] GameObject KnifeBlank;
    [SerializeField] GameObject BatBlank;
    [SerializeField] GameObject AxeBlank;
    [SerializeField] GameObject GunBlank;
     [SerializeField] GameObject Inv1;
     [SerializeField] GameObject Inv2;
     [SerializeField] GameObject key1Blank;
     [SerializeField] GameObject key2Blank;
     [SerializeField] GameObject key3Blank;
     [SerializeField] GameObject Gass;
     [SerializeField] GameObject FlashLight;
    [SerializeField] GameObject lockPick;
     [SerializeField] GameObject Ammo;

    // invisible in inspector
    [SerializeField] bool InventoryActive = false;
    private bool ExitInvetory = true;

    // Start is called before the first frame update
    void Start()
    {
         Inv1.gameObject.SetActive(true);
         Inv2.gameObject.SetActive(false);
        InventoryMenu.gameObject.SetActive(false);
         ControlsMenu.ControlsOpen=false;
        ControlsMenu.OptionsOpen=false;
        InventoryActive = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Tab))
        {
                  if(ControlsMenu.ControlsOpen==false&&ControlsMenu.OptionsOpen==false){ 
            if (InventoryActive == false)
            {
                  
                ExitInvetory = false;
                StartCoroutine(InventoryOpen());
                 //  ControlsMenu.CanShow=false;
                 ControlsMenu.ControlsOpen=true;
                    ControlsMenu.OptionsOpen=true;
                    SaveScript.CanShot=false;
       }
            }

            else 
           if (InventoryActive == true)
            {
                if (ExitInvetory == true)
                { 
                      if(ControlsMenu.ControlsOpen==true){ 
                Time.timeScale = 1f;
                InventoryMenu.gameObject.SetActive(false);
                         Inv1.gameObject.SetActive(true);
         Inv2.gameObject.SetActive(false);
                InventoryActive = false;
                Cursor.visible = false;
                   ControlsMenu.ControlsOpen=false;
                          ControlsMenu.OptionsOpen=false;
                        SaveScript.CanShot=true;
                }}
            }
        
    }}
    public void ChoseKnife()
    {
        SaveScript.weaponID = 1;
        SaveScript.weaponChange = true;
    }

    public void ChoseBat()
    {
        SaveScript.weaponID = 2;
        SaveScript.weaponChange = true;
    }

    public void ChoseAxe()
    {
        SaveScript.weaponID = 3;
        SaveScript.weaponChange = true;
    }

    public void ChoseGun()
    {
        SaveScript.weaponID = 4;
        SaveScript.weaponChange = true;
    }

  
     IEnumerator InventoryOpen()
    {
        InventoryMenu.gameObject.SetActive(true);
        InventoryCheck();
        InventoryActive = true;
        Cursor.visible = true;
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
        ExitInvetory = true;
        

    }
   




    void InventoryCheck()

    {
       // SaveScript.HaveAxe = true;

        if (SaveScript.HaveKnife == true)

        {

            KnifeBlank.gameObject.SetActive(false);

            KnifeImage.gameObject.SetActive(true);

            KnifeButton.gameObject.SetActive(true);

        }

        if (SaveScript.HaveKnife == false)

        {

            KnifeBlank.gameObject.SetActive(true);

            KnifeImage.gameObject.SetActive(false);

            KnifeButton.gameObject.SetActive(false);

        }

        if (SaveScript.HaveBat == true)

        {

            BatBlank.gameObject.SetActive(false);

            BatImage.gameObject.SetActive(true);

            BatButton.gameObject.SetActive(true);

        }

        if (SaveScript.HaveBat == false)

        {

            BatBlank.gameObject.SetActive(true);

            BatImage.gameObject.SetActive(false);

            BatButton.gameObject.SetActive(false);

        }

        if (SaveScript.HaveAxe == true)

        {

            AxeBlank.gameObject.SetActive(false);

            AxeImage.gameObject.SetActive(true);

            AxeButton.gameObject.SetActive(true);

        }

        if (SaveScript.HaveAxe == false)

        {

            AxeBlank.gameObject.SetActive(true);

            AxeImage.gameObject.SetActive(false);

            AxeButton.gameObject.SetActive(false);

        }

        if (SaveScript.HaveGun == true)

        {

            GunBlank.gameObject.SetActive(false);

            GunImage.gameObject.SetActive(true);

            GunButton.gameObject.SetActive(true);

        }

        if (SaveScript.HaveGun == false)

        {

            GunBlank.gameObject.SetActive(true);

            GunImage.gameObject.SetActive(false);

            GunButton.gameObject.SetActive(false);

        }

         if (SaveScript.HaveKey == true)

        {

           key1Blank.gameObject.SetActive(false);


        }

        if (SaveScript.HaveKey == false)

        {

            key1Blank.gameObject.SetActive(true);

            

        }
        if (SaveScript.HaveKey2 == true)

        {

           key2Blank.gameObject.SetActive(false);


        }

        if (SaveScript.HaveKey2 == false)

        {

            key2Blank.gameObject.SetActive(true);

            

        }
        if (SaveScript.HaveKey3 == true)

        {

           key3Blank.gameObject.SetActive(false);


        }

        if (SaveScript.HaveKey3 == false)

        {

            key3Blank.gameObject.SetActive(true);

            

        }



          if (SaveScript.HaveFlashlightOn == true)

        {

           FlashLight.gameObject.SetActive(false);


        }

        if (SaveScript.FlashlightOn == false)

        {

            FlashLight.gameObject.SetActive(true);

            

        }

          if (SaveScript.Gass == true)

        {

           Gass.gameObject.SetActive(false);


        }

        if (SaveScript.Gass == false)

        {

            Gass.gameObject.SetActive(true);

            

        }

         if (SaveScript.Ammo == false)

        {

           Ammo.gameObject.SetActive(false);


        }

        if (SaveScript.Ammo == true)

        {

            Ammo.gameObject.SetActive(true);

            

        }

         if (SaveScript.LockPick1 == false || SaveScript.LockPick2 == false || SaveScript.LockPick3 == false)

        {

           lockPick.gameObject.SetActive(false);


        }

        if (SaveScript.LockPick1 == true || SaveScript.LockPick2 == true || SaveScript.LockPick3 == true)

        {

            lockPick.gameObject.SetActive(true);

            

        }




      
        
    }
    public void SwichOn(){
         Inv1.gameObject.SetActive(false);
         Inv2.gameObject.SetActive(true);
        
}

     public void SwitchOff(){
         Inv1.gameObject.SetActive(true);
         Inv2.gameObject.SetActive(false);
        
}

}
