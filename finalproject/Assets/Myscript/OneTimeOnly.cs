using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeOnly : MonoBehaviour
{
    [SerializeField] GameObject flashLight;
    [SerializeField] GameObject Apple1;
    [SerializeField] GameObject Apple2;
    [SerializeField] GameObject Apple3;
    [SerializeField] GameObject Apple4;
    [SerializeField] GameObject Baterry1;
    [SerializeField] GameObject Baterry2;
    [SerializeField] GameObject Baterry3;
    [SerializeField] GameObject Baterry4;
    [SerializeField] GameObject Baterry5;
    [SerializeField] GameObject axe;
    [SerializeField] GameObject knife;
    [SerializeField] GameObject Bat;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject Lockpick1;
    [SerializeField] GameObject Lockpick2;
    [SerializeField] GameObject Lockpick3;
    [SerializeField] GameObject Gass;
    [SerializeField] GameObject Ammo;
    [SerializeField] GameObject Key1;
    [SerializeField] GameObject Key2;
    [SerializeField] GameObject Key3;
    [SerializeField] GameObject butcher;
    [SerializeField] GameObject killScene;

    // Start is called before the first frame update
    void Start()
    {
        if (SaveScript.HaveFlashlightOn == true) {
            Destroy(flashLight, 0.2f);
        }
        if (SaveScript.Apple1 == false)
        {
            Destroy(Apple1, 0.2f);
        }
        if (SaveScript.Apple2 == false)
        {
            Destroy(Apple2, 0.2f);
        }
        if (SaveScript.Apple3 == false)
        {
            Destroy(Apple3, 0.2f);
        }
        if (SaveScript.Apple4 == false)
        {
            Destroy(Apple4, 0.2f);
        }
        if (SaveScript.Baterry1 == false)
        {
            Destroy(Baterry1, 0.2f);
        }
        if (SaveScript.Baterry2 == false)
        {
            Destroy(Baterry2, 0.2f);
        }
        if (SaveScript.Baterry3 == false)
        {
            Destroy(Baterry3, 0.2f);
        }
        if (SaveScript.Baterry4 == false)
        {
            Destroy(Baterry4, 0.2f);
        }
        if (SaveScript.Baterry5 == false)
        {
            Destroy(Baterry5, 0.2f);
        }



        if (SaveScript.HaveAxe == true)
        {
            Destroy(axe, 0.2f);
        }
        if (SaveScript.HaveBat == true)
        {
            Destroy(Bat, 0.2f);
        }
        if (SaveScript.HaveKnife == true)
        {
            Destroy(knife, 0.2f);
        }
        if (SaveScript.HaveGun == true)
        {
            Destroy(gun, 0.2f);
        }
        if (SaveScript.Gass == true)
        {
            Destroy(Gass, 0.2f);
        }
        if (SaveScript.HaveKey == true)
        {
            Destroy(Key1, 0.2f);
        }
        if (SaveScript.HaveKey2 == true)
        {
            Destroy(Key2, 0.2f);
        }
        if (SaveScript.HaveKey3 == true)
        {
            Destroy(Key3, 0.2f);
        }

        if (SaveScript.LockPick1 == false)
        {
            Destroy(Lockpick1, 0.2f);
        }
        if (SaveScript.LockPick2 == false)
        {
            Destroy(Lockpick2, 0.2f);
        }
        if (SaveScript.LockPick3 == false)
        {
            Destroy(Lockpick3, 0.2f);
        }
        if (SaveScript.Ammo == false)
        {
            Destroy(Ammo, 0.2f);
        }
        if (SaveScript.Cinma3 == false)
        {
            killScene.gameObject.SetActive(true);
        }
        if (SaveScript.CinmaKillScene == false)
        {
            killScene.gameObject.SetActive(false);
            butcher.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
