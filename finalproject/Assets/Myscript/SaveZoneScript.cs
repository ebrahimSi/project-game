using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveZoneScript : MonoBehaviour
{
    private float DifficultyLevel;
    private int BatteryNumber;
    private float PowerBattery;
    private int PlayersHealth;
    private int Knife;
    private int Axe;
    private int Bat;
    private int Gun;
    private int BulletsLeft;
    private int Enemy1a;
    private int Enemy2a;
    private int Enemy3a;
    private int Enemy4a;
    private int Enemy5a;
    private int Enemy6a;
    [SerializeField] int SaveNumber ;
    private int Location;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (SaveScript.SaveZone == true)
        {
            if (SaveScript.HaveKnife == true)
            {
                Knife = 1;
            }
            if (SaveScript.HaveKnife == false)
            {
                Knife = 0;
            }
            if (SaveScript.HaveAxe == true)
            {
                Axe = 1;
            }
            if (SaveScript.HaveAxe == false)
            {
                Axe = 0;
            }
            if (SaveScript.HaveBat == true)
            {
                Bat = 1;
            }
            if (SaveScript.HaveBat == false)
            {
                Bat = 0;
            }
            if (SaveScript.HaveGun == true)
            {
                Gun = 1;
            }
            if (SaveScript.HaveGun == false)
            {
                Gun = 0;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                PlayerPrefs.SetFloat("DifficultyLevel", SaveScript.Difficulty);
                PlayerPrefs.SetInt("BatteryNumber", SaveScript.Batteries);
                PlayerPrefs.SetFloat("PowerBattery", SaveScript.BatteryPower);
                PlayerPrefs.SetInt("PlayersHealth", SaveScript.PlayerHealth);
                SaveScript.SaveNumber++;
                PlayerPrefs.SetInt("Save", SaveScript.SaveNumber);
                PlayerPrefs.SetInt("Cinma1", SaveScript.Cinma1?0:1);
                PlayerPrefs.SetInt("Cinma2", SaveScript.Cinma2 ? 1 : 0);
                PlayerPrefs.SetInt("Cinma3", SaveScript.Cinma3 ? 1 : 0);
                PlayerPrefs.SetInt("Cinma4", SaveScript.Cinma4 ? 1 : 0);
                PlayerPrefs.SetInt("Message1", SaveScript.MassgeTrigg1 ? 1 : 0);
                PlayerPrefs.SetInt("Message2", SaveScript.MassgeTrigg2 ? 1 : 0);
                PlayerPrefs.SetInt("Message3", SaveScript.MassgeTrigg3 ? 1 : 0);
                //   PlayerPrefs.SetInt("BulletsLeft", SaveScript.Bullets);
                PlayerPrefs.SetInt("Knife", Knife);
                PlayerPrefs.SetInt("Axe", Axe);
                PlayerPrefs.SetInt("Bat", Bat);
                PlayerPrefs.SetInt("Gun", Gun);



                if (SaveScript.Enemy1 == 0)
                {
                    PlayerPrefs.SetInt("Enemy1a", SaveScript.Enemy1);
                }
                if (SaveScript.Enemy2 == 0)
                {
                    PlayerPrefs.SetInt("Enemy2a", SaveScript.Enemy2);
                }
                if (SaveScript.Enemy3 == 0)
                {
                    PlayerPrefs.SetInt("Enemy3a", SaveScript.Enemy3);
                }
                if (SaveScript.Enemy4 == 0)
                {
                    PlayerPrefs.SetInt("Enemy4a", SaveScript.Enemy4);
                }
                if (SaveScript.Enemy5 == 0)
                {
                    PlayerPrefs.SetInt("Enemy5a", SaveScript.Enemy5);
                }
                if (SaveScript.Enemy6 == 0)
                {
                    PlayerPrefs.SetInt("Enemy6a", SaveScript.Enemy6);
                }
                SaveScript.SaveLocation = 3;
                PlayerPrefs.SetInt("Location", SaveScript.SaveLocation);
                PlayerPrefs.Save();
               
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.SaveZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.SaveZone = false;
        }
    }
    
}