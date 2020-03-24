using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{

    [SerializeField] GameObject Controls;
    public static bool ControlsOpen = false;
    
    [SerializeField] GameObject Options;
    public static bool OptionsOpen = false;
    private bool SaveMessageActive = false;
    [SerializeField] GameObject SaveMessage;
    private bool MenuReturn = false;
    [SerializeField] GameObject BackToMenu;
    [SerializeField] GameObject MainMenuLoad;
    // Start is called before the first frame update
    void Start()
    {
        Controls.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        SaveMessage.gameObject.SetActive(false);
        BackToMenu.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Application.Quit();
        }
        //
          if (OptionsOpen == false)
            {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                
            if ( ControlsOpen == false)
            {
                Controls.gameObject.SetActive(true);
                ControlsOpen = true;
                 Cursor.visible = true;
                    SaveScript.CanShot=false;
                    
            Time.timeScale = 0;
            }
            else if ( ControlsOpen == true)
            {
                Controls.gameObject.SetActive(false);
                ControlsOpen = false;
                 Cursor.visible = false;  
            Time.timeScale = 1;
                    SaveScript.CanShot=true;
            }}
        }
        //
        if(ControlsOpen==false){
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (OptionsOpen == false)
            {
                Options.gameObject.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
                    
                OptionsOpen = true;
                    SaveScript.CanShot=false;
            }
            else if (OptionsOpen == true)
            {
                Options.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
                    SaveScript.CanShow = false;
                OptionsOpen = false;
                    SaveScript.CanShot=true;
            }
            //
           
        }
         if(OptionsOpen==false){
        if (SaveScript.SaveZone == true)
        {
            if (SaveMessageActive == false)
            {
                SaveMessage.gameObject.SetActive(true);
                SaveMessageActive = true;
            }
        }
        else if (SaveScript.SaveZone == false)
        {
            if (SaveMessageActive == true)
            {
                SaveMessage.gameObject.SetActive(false);
                SaveMessageActive = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (MenuReturn == false)
            {
                BackToMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                MenuReturn = true;
                         OptionsOpen = true;
                         ControlsOpen = true;
                        SaveScript.CanShow = true;
                        SaveScript.CanShot=false;
            }
        }
    }
}}
    public void ReturnToGame()
    {
        if (MenuReturn == true)
        {
            BackToMenu.gameObject.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1;
            MenuReturn = false;
             OptionsOpen =false;
                         ControlsOpen = false;
            SaveScript.CanShow = false;
            SaveScript.CanShot=true;

        }
    }
    public void LoadMenu()
    {
        MainMenuLoad.gameObject.SetActive(true);
    }
}