using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseMenu : MonoBehaviour {

    public GameObject pauseMenuUi;

	public static bool IsPaused = false;

    

    public void Start()
    { 

	}
	
    public void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape)) 
        {

            if (ControlsMenu.OptionsOpen == false)
            {
                if (IsPaused = !IsPaused)
                {
                    Time.timeScale = 0;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    ControlsMenu.ControlsOpen = true;
                    IsPaused = false;
                    pauseMenuUi.SetActive(true);
                    SaveScript.CanShot = false;

                }
            }

        }
	}
    


	//--------------------------------------------------------------//

	// Update is called once per frame
	public void ResumeGame () 
	{

		Time.timeScale = 1;
		Cursor.visible = false;
		IsPaused = false;
		pauseMenuUi.SetActive(false);
        ControlsMenu.ControlsOpen = false;
        SaveScript.CanShot = true;
    }

  }

