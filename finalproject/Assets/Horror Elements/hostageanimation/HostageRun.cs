using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostageRun : MonoBehaviour
{
    void Start()
    {
        if (SaveScript.Cinmajohn == false)
        {
            this.gameObject.GetComponentInParent<HostageFollow2>().enabled = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {

      
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.GetComponentInParent<HostageFollow2>().enabled = true;
           // Destroy(this.gameObject, 0.2f);
        }

    }
}
