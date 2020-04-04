using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static bool LoadGame = false;
    [SerializeField] GameObject LoadButton;
    public int DataExists = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        LoadButton.gameObject.SetActive(false);
        DataExists = PlayerPrefs.GetInt("Save", 0);
        MenuButton();
    }
    void MenuButton()
    {
        if (DataExists > 0)
        {
           LoadButton.gameObject.SetActive(true);
        }
    }
    public void LoadGameData()
    {
        LoadGame = true;
    }
    public void NewGameData()
    {
        LoadGame = false;
        //PlayerPrefs.DeleteAll();
       // SaveScript.Cinma1 = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}