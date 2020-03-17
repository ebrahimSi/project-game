using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneymeBulletDamge : MonoBehaviour
{
   
    [SerializeField] int WeaponDamage = 60;
    AudioSource HitSound;
    private bool HitActive = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
        HitSound = GetComponent<AudioSource>();
        Destroy(this.gameObject, 0.5f);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        HitSound.Play(0);
      //  if (other.gameObject.CompareTag("Player"))
       // {
//if (HitActive == false)
         //   {
              
              //      HitActive = true;
                    
               //     HitSound.Play(0);
                //    SaveScript.PlayerHealth -= WeaponDamage;
               //     SaveScript.DisplayHealth = true;
              
           // }
        //}
    }
    private void OnTriggerExit(Collider other)
    {
      //  if (other.gameObject.CompareTag("Player"))
       // {
        //    if (HitActive == true)
         //   {
              //  HitActive = false;

         //   }
       // }
    }
}
