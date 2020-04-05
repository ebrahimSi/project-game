using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int EnemysHealth = 100;
    [SerializeField] int BatDamage = 10;
    [SerializeField] int KnifeDamage = 30;
    [SerializeField] int AxeDamage = 60;
    [SerializeField] int GunDamage = 85;
    private Animator anim;
    private bool PlayerHitMe = false;
    private bool WakeUp = true;
    AudioSource HitEnemy;
     [SerializeField] GameObject ChaseMusic;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
        HitEnemy = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemysHealth <= 0)
        {
            
         
                 EnemysHealth = 100;
            anim.SetBool("Die", true);
            anim.SetBool("Wake", false);
             ChaseMusic.gameObject.SetActive(false);
             
             StartCoroutine(Wake());
              
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PBat"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemysHealth -= BatDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }
        if (other.gameObject.CompareTag("PKnife"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemysHealth -= KnifeDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
                EnemysHealth -= AxeDamage;
                anim.SetTrigger("React");
                HitEnemy.Play(0);
            }
        }
        if (other.gameObject.CompareTag("PGun"))
        {
            if (PlayerHitMe == false)
            {
                PlayerHitMe = true;
               EnemysHealth -= GunDamage;
               anim.SetTrigger("React");
               HitEnemy.Play(0);
          }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PBat"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
        if (other.gameObject.CompareTag("PKnife"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
            }
        }
        if (other.gameObject.CompareTag("PGun"))
        {
            if (PlayerHitMe == true)
            {
                PlayerHitMe = false;
           }
        }
    }
     IEnumerator Wake()
    {

        yield return new WaitForSeconds(10f);
       
       anim.SetBool("Wake", true);
       anim.SetInteger("State", 0);
        anim.SetBool("Alert", false);
        anim.SetBool("AxeAttacks", false);
               anim.SetBool("Damaging", false);
    //    anim.SetBool("React");
        anim.SetBool("Die", false);

      //  SaveScript.Cinma1 = PlayerPrefs.GetInt("Cinma1") == 1 ? true : false;




    }
}