using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{

    [SerializeField] GameObject Controls;
    private bool ControlsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        Controls.gameObject.SetActive(false);
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
    }
}
