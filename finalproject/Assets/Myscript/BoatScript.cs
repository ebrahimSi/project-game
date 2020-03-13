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
    private bool MenuReturn = false;
    [SerializeField] GameObject MainMenuLoad;
    public GameObject TextBox;
    public AudioSource JhonFindSound;
    public AudioSource gassolineSound;
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
              
                    if (MenuReturn == false)
                    {
                        BoatMenu.gameObject.SetActive(true);
                        Time.timeScale = 0;
                        Cursor.visible = true;
                        MenuReturn = true;
                    BoatMessage.gameObject.SetActive(false);
                }
                  //  BoatMenu.gameObject.SetActive(true);
                   // Time.timeScale = 0;
//Cursor.visible = true;
               

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
    public void ReturnToGame()
    {
        if (MenuReturn == true)
        {
            BoatMenu.gameObject.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1;
            MenuReturn = false;
            BoatMessage.gameObject.SetActive(true);
        }
    }
    public void LoadMenu()
    {

        if (SaveScript.Gass == true && SaveScript.Hostage == true)
        {
          
                MainMenuLoad.gameObject.SetActive(true);
          
            //  BoatMenu.gameObject.SetActive(true);
            // Time.timeScale = 0;
            //Cursor.visible = true;
        }
        else if (SaveScript.Gass == false && SaveScript.Hostage == false)
        {

            MassageText.text = "I cant leave without john";
            Enter = false;
            ReturnToGame();
            StartCoroutine(ScenePlayer(1));
        }
        else if (SaveScript.Gass == false)
        {
            MassageText.text = "I need to find gasoline to start the boat";
            Enter = false;
            ReturnToGame();
            StartCoroutine(ScenePlayer(2));
        }
        else
        {

            MassageText.text = " I cant leave without john";
            Enter = false;
            ReturnToGame();
            StartCoroutine(ScenePlayer(1));
        }
    }
    IEnumerator ScenePlayer(int number)
    {
        if (number == 1)
        {
            yield return new WaitForSeconds(1.5f);
            JhonFindSound.Play();
            TextBox.GetComponent<Text>().text = "I cant leave without john !!";
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = "i neeed john !!";
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = "";
        }else  if (number == 2)
        {
            yield return new WaitForSeconds(1.5f);
            gassolineSound.Play();
            TextBox.GetComponent<Text>().text = "I need to find gasoline to start the boat !!";
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = "where the gasoline? !!";
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = "";
        }


    }
}
