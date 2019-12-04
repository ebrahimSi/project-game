using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    private int currentWeapon;
    [SerializeField] GameObject Knife;
    [SerializeField] GameObject BaseballBat;
    [SerializeField] GameObject Axe;
    [SerializeField] GameObject Gun;
    [SerializeField] float WaitTime = 1.0f;

    private Animator anim;
    private bool WeaponVisible = false;
    private bool Attack = true;

    // Start is called before the first frame update
    void Start()
    {

        SaveScript.weaponChange = true;
        currentWeapon = SaveScript.weaponID;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SaveScript.weaponChange == true)
        {
            AssignWeapon();
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (WeaponVisible == true)
            {
                WeaponVisible = false;
                anim.SetBool("Ready", false);
            }
        }


        if (currentWeapon > 0 && currentWeapon < 4)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (WeaponVisible == false)
                {
                    WeaponVisible = true;
                    anim.SetBool("Ready", true);
                }

                else if (WeaponVisible == true)
                {
                    WeaponVisible = false;
                    anim.SetBool("Ready", false);
                }
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (Attack == true)
                {
                    if (currentWeapon == 1)
                    {
                        anim.SetInteger("WeaponStrike", 1);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }

                    if (currentWeapon == 2)
                    {
                        anim.SetInteger("WeaponStrike", 2);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }

                    if (currentWeapon == 3)
                    {
                        anim.SetInteger("WeaponStrike", 3);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }
                }




            }
        }
        if (currentWeapon == 4)
        {

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (WeaponVisible == false)
                {
                    WeaponVisible = true;
                    anim.SetBool("GunAim", true);
                }

                else if (WeaponVisible == true)
                {
                    WeaponVisible = false;
                    anim.SetBool("GunAim", false);
                }


            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (Attack == true)
                {
                    if (currentWeapon == 4)
                    {
                        anim.SetInteger("WeaponStrike", 4);
                        Attack = false;
                        StartCoroutine(WeaponWait());
                    }


                }
            }
        }

       
    }

    void AssignWeapon()
    {
        SaveScript.weaponChange = false;
        currentWeapon = SaveScript.weaponID;

        if (currentWeapon == 0)
        {
            Knife.gameObject.SetActive(false);
            BaseballBat.gameObject.SetActive(false);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(false);
        }

        if (currentWeapon == 1)
        {
            Knife.gameObject.SetActive(true);
            BaseballBat.gameObject.SetActive(false);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(false);
            WaitTime = 1.0f;
        }

        if (currentWeapon == 2)
        {
            Knife.gameObject.SetActive(false);
            BaseballBat.gameObject.SetActive(true);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(false);
            WaitTime = 1.5f;
        }

        if (currentWeapon == 3)
        {
            Knife.gameObject.SetActive(false);
            BaseballBat.gameObject.SetActive(false);
            Axe.gameObject.SetActive(true);
            Gun.gameObject.SetActive(false);
            WaitTime = 1.5f;
        }

        if (currentWeapon == 4)
        {
            Knife.gameObject.SetActive(false);
            BaseballBat.gameObject.SetActive(false);
            Axe.gameObject.SetActive(false);
            Gun.gameObject.SetActive(true);
            WaitTime = 0.5f;
        }
    }
     IEnumerator WeaponWait()
    {
        yield return new WaitForSeconds(WaitTime);
        Attack = true;
        anim.SetInteger("WeaponStrike", 0);
    }
}
