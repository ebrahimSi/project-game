using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static bool LoadGame = false;
    [SerializeField] GameObject LoadButton;
    public int DataExists = 10;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        LoadButton.gameObject.SetActive(false);
        DataExists = PlayerPrefs.GetInt("PlayersHealth", 0);
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
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}