using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{

    [SerializeField] GameObject Controls;
    private bool ControlsOpen = false;

    [SerializeField] GameObject Options;
    private bool OptionsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        Controls.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(ControlsOpen == false)
            {
                Controls.gameObject.SetActive(true);
                ControlsOpen = true;
            }
            else if(ControlsOpen == true)
            {
                Controls.gameObject.SetActive(false);
                ControlsOpen = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (OptionsOpen == false)
            {
                Controls.gameObject.SetActive(false);
                Options.gameObject.SetActive(true);

                Cursor.visible = true;
                Time.timeScale = 0;
                OptionsOpen = true;
            }
            else if (OptionsOpen == true)
            {
                Options.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
                OptionsOpen = false;
            }
        }

    }
}
