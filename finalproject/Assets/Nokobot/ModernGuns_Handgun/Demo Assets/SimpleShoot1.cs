using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot1 : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public Transform casingExitLocation;


    public float shotPower = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (SaveScript.Bullets>0)
            {
                GetComponent<Animator>().SetTrigger("Fire");
                Shoot();
            }
        }
    }

    void Shoot()
    {
         GameObject bullet;
         bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
       bullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
        SaveScript.Bullets -= 1;
        if (SaveScript.Bullets <=0) {
            SaveScript.Bullets = 0;
        }
        GameObject tempFlash;
      // Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
       tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
        Destroy(bullet, 0.5f);
        Destroy(tempFlash, 0.5f);
        //  Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation).GetComponent<Rigidbody>().AddForce(casingExitLocation.right * 100f);
      
    }

    void CasingRelease()
    {
         GameObject casing;
        casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);
    }


}
