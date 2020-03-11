using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickTrigger : MonoBehaviour
{
    AudioSource aSource;
    public Transform Lockpick;
    public int lpAmount = 1;
    public bool destroyAfterTaking;

    void Start()
    {

        aSource = Lockpick.GetComponent<AudioSource>();


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            aSource.Play();
            other.GetComponent<Inventar>()._lpCount += lpAmount;
            if (destroyAfterTaking)

                Destroy(gameObject);

        }
    }

}