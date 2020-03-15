using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaFootSound : MonoBehaviour
{
    [SerializeField] GameObject player;
    public int type;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<FootSound>().Type = type;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<FootSound>().Type = 1;

        }

    }


    // Update is called once per frame
   
}
