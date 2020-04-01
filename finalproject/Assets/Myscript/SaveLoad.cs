using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] GameObject EnemyNumber1;
    [SerializeField] GameObject EnemyNumber2;
    [SerializeField] GameObject EnemyNumber3;
    [SerializeField] GameObject EnemyNumber4;
    [SerializeField] GameObject EnemyNumber5;
    [SerializeField] GameObject EnemyNumber6;
    [SerializeField] Transform SaveArea1;
    [SerializeField] Transform SaveArea2;
    [SerializeField] Transform SaveArea3;
    [SerializeField] Transform SaveArea4;
    [SerializeField] Transform PlayerCharacter;
    // Start is called before the first frame update
    void Start()
    {
        if (MenuScript.LoadGame == true)
        {
            SaveScript.Difficulty = PlayerPrefs.GetFloat("DifficultyLevel");
            SaveScript.Batteries = PlayerPrefs.GetInt("BatteryNumber");
            SaveScript.BatteryPower = PlayerPrefs.GetFloat("PowerBattery");
            SaveScript.PlayerHealth = PlayerPrefs.GetInt("PlayersHealth");
            PlayerPrefs.SetInt("Save", SaveScript.SaveNumber);
            SaveScript.Cinma1 = PlayerPrefs.GetInt("Cinma1")==1?true:false;
            //    SaveScript.Bullets = PlayerPrefs.GetInt("BulletsLeft");
            if (PlayerPrefs.GetInt("Knife") == 1)
            {
                SaveScript.HaveKnife = true;
            }
            if (PlayerPrefs.GetInt("Knife") == 0)
            {
                SaveScript.HaveKnife = false;
            }
            if (PlayerPrefs.GetInt("Axe") == 1)
            {
                SaveScript.HaveAxe = true;
            }
            if (PlayerPrefs.GetInt("Axe") == 0)
            {
                SaveScript.HaveAxe = false;
            }
            if (PlayerPrefs.GetInt("Bat") == 1)
            {
                SaveScript.HaveBat = true;
            }
            if (PlayerPrefs.GetInt("Bat") == 0)
            {
                SaveScript.HaveBat = false;
            }
            if (PlayerPrefs.GetInt("Gun") == 1)
            {
                SaveScript.HaveGun = true;
            }
            if (PlayerPrefs.GetInt("Gun") == 0)
            {
                SaveScript.HaveGun = false;
            }
          
            if (PlayerPrefs.GetInt("Enemy1a") == 0)
            {
                EnemyNumber1.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Enemy2a") == 0)
            {
                EnemyNumber2.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Enemy3a") == 0)
            {
                EnemyNumber3.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Enemy4a") == 0)
            {
                EnemyNumber4.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Enemy5a") == 0)
            {
                EnemyNumber5.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Enemy6a") == 0)
            {
                EnemyNumber6.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Location") == 1)
            {
                StartCoroutine(ScenePlayer());
            }
            if (PlayerPrefs.GetInt("Location") == 2)
            {
                StartCoroutine(ScenePlayer());
            }
            if (PlayerPrefs.GetInt("Location") == 3)
            {
                StartCoroutine(ScenePlayer());
            }
            if (PlayerPrefs.GetInt("Location") == 4)
            {
                StartCoroutine(ScenePlayer());
            }
        }
        if (MenuScript.LoadGame == false)
        {
            SaveScript.Difficulty = 1f;
            SaveScript.weaponID = 0;
            SaveScript.Batteries = 0;
            SaveScript.BatteryPower = 1f;
            SaveScript.PlayerHealth = 30;
            SaveScript.HaveKnife = false;
            SaveScript.HaveBat = false;
            SaveScript.HaveAxe = false;
            SaveScript.HaveGun = false;
      //      SaveScript.Bullets = 8;
            SaveScript.SaveZone = false;
            SaveScript.Enemy1 = 1;
            SaveScript.Enemy2 = 1;
            SaveScript.Enemy3 = 1;
            SaveScript.Enemy4 = 1;
            SaveScript.Enemy5 = 1;
            SaveScript.Enemy6 = 1;
            SaveScript.SaveLocation = 0;
        }
    }
    IEnumerator ScenePlayer()
    {

        yield return new WaitForSeconds(0.00000000000000000000000000000000000000000000000009f);
        PlayerCharacter.transform.position = new Vector3(650.6f, 22.13f, 370.8f);
       




    }



}