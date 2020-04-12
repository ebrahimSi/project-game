using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
    [SerializeField] Transform john;
    [SerializeField] Transform Objectev1;
    [SerializeField] Transform Objectev2;
    [SerializeField] Transform Objectev3;
    [SerializeField] Transform Objectev4;
    // Start is called before the first frame update
    void Start()
    {
        if (MenuScript.LoadGame == true)
        {
            SaveScript.Difficulty = PlayerPrefs.GetFloat("DifficultyLevel");
            SaveScript.Batteries = PlayerPrefs.GetInt("BatteryNumber");
            SaveScript.BatteryPower = PlayerPrefs.GetFloat("PowerBattery");
            SaveScript.PlayerHealth = PlayerPrefs.GetInt("PlayersHealth");
            SaveScript.Bullets = PlayerPrefs.GetInt("Bullets");
            SaveScript.Objectev = PlayerPrefs.GetInt("Objectev");
            PlayerPrefs.SetInt("Save", SaveScript.SaveNumber);
            SaveScript.Cinma1 = PlayerPrefs.GetInt("Cinma1")==1?true:false;
            SaveScript.Cinma2 = PlayerPrefs.GetInt("Cinma2") == 1 ? true : false;
            SaveScript.Cinma3 = PlayerPrefs.GetInt("Cinma3") == 1 ? true : false;
            SaveScript.Cinma4 = PlayerPrefs.GetInt("Cinma4") == 1 ? true : false;
            SaveScript.Cinma4 = PlayerPrefs.GetInt("Cinma5") == 1 ? true : false;
            SaveScript.Cinmajohn = PlayerPrefs.GetInt("Cinmajohn") == 1 ? true : false;
            SaveScript.MassgeTrigg1 = PlayerPrefs.GetInt("Message1") == 1 ? true : false;
            SaveScript.MassgeTrigg2 = PlayerPrefs.GetInt("Message2") == 1 ? true : false;
            SaveScript.MassgeTrigg3 = PlayerPrefs.GetInt("Message3") == 1 ? true : false;
            SaveScript.HaveFlashlightOn = PlayerPrefs.GetInt("FlashLight") == 1 ? true : false;
            SaveScript.Apple1 = PlayerPrefs.GetInt("Apple1") == 1 ? true : false;
            SaveScript.Apple2 = PlayerPrefs.GetInt("Apple2") == 1 ? true : false;
            SaveScript.Apple3 = PlayerPrefs.GetInt("Apple3") == 1 ? true : false;
            SaveScript.Baterry1 = PlayerPrefs.GetInt("Baterry1") == 1 ? true : false;
            SaveScript.Baterry2 = PlayerPrefs.GetInt("Baterry2") == 1 ? true : false;
            SaveScript.Baterry3 = PlayerPrefs.GetInt("Baterry3") == 1 ? true : false;
            SaveScript.Baterry4 = PlayerPrefs.GetInt("Baterry4") == 1 ? true : false;
            SaveScript.Baterry5 = PlayerPrefs.GetInt("Baterry5") == 1 ? true : false;
            SaveScript.LockPick1 = PlayerPrefs.GetInt("lockPic1") == 1 ? true : false;
            SaveScript.LockPick2 = PlayerPrefs.GetInt("lockPic2") == 1 ? true : false;
            SaveScript.LockPick3 = PlayerPrefs.GetInt("lockPic3") == 1 ? true : false;
            SaveScript.Gass = PlayerPrefs.GetInt("Gass") == 1 ? true : false;
            SaveScript.Ammo = PlayerPrefs.GetInt("Ammo") == 1 ? true : false;
            SaveScript.HaveKey = PlayerPrefs.GetInt("Key1") == 1 ? true : false;
            SaveScript.HaveKey2 = PlayerPrefs.GetInt("Key2") == 1 ? true : false;
            SaveScript.HaveKey3 = PlayerPrefs.GetInt("Key3") == 1 ? true : false;
            SaveScript.Objectev1 = PlayerPrefs.GetInt("Objectev1") == 1 ? true : false;
            SaveScript.NoteObjectev2 = PlayerPrefs.GetInt("NoteObjectev2") == 1 ? true : false;
            SaveScript.CinmaKillScene = PlayerPrefs.GetInt("CinmakillScene") == 1 ? true : false;
            PlayerCharacter.GetComponent<Inventar>()._lpCount= PlayerPrefs.GetInt("LockPick");
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
            if (PlayerPrefs.GetInt("Objectev") == 1)
            {
                Objectev1.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Objectev") == 2)
            {
                Objectev2.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Objectev") == 3)
            {
                Objectev3.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Objectev") == 4)
            {
                Objectev4.gameObject.SetActive(true);
            }
        }
        if (MenuScript.LoadGame == false)
        {
            SaveScript.Difficulty = 0.5f;
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
            PlayerPrefs.DeleteAll();
        }
    }
    IEnumerator ScenePlayer()
    {

        yield return new WaitForSeconds(0f);
        PlayerCharacter.transform.position = new Vector3(650.6f, 22.13f, 370.8f);
        if (SaveScript.Cinmajohn==false) {
            john.GetComponent<NavMeshAgent>().enabled = false;
            john.transform.position = new Vector3(655.51f, 16.66f, 404.4f);
            john.GetComponent<NavMeshAgent>().enabled = true; }
        //  SaveScript.Cinma1 = PlayerPrefs.GetInt("Cinma1") == 1 ? true : false;




    }



}