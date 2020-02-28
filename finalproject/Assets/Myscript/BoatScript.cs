using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoatScript : MonoBehaviour
{
    [SerializeField] GameObject BoatMenu;
    private bool Enter=false;
    [SerializeField] GameObject BoatMessage;
    [SerializeField] Text MassageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (SaveScript.Gass == true && SaveScript.Hostage == true)
                {
                    BoatMenu.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    Cursor.visible = true;
                }else if (SaveScript.Gass == false && SaveScript.Hostage == false)
                {
                    MassageText.text = "Need Gass  and friend";

                }else if (SaveScript.Gass == false)
                {
                    MassageText.text = "Need Gass";

                }
                else
                {

                    MassageText.text = " you must be help your friend";
                }

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            BoatMessage.gameObject.SetActive(true);
            Enter = true;
        } }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MassageText.text = "press E to run";
            BoatMessage.gameObject.SetActive(false);
            Enter = false;
        }
    }
}
