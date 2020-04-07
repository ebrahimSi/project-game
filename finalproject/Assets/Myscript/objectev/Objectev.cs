using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectev : MonoBehaviour
{
    public GameObject Panel;
    void Start() { }
    void OnTriggerEnter(Collider Other) {
        if (Other.gameObject.CompareTag("Player")) {
            Panel.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider Other) {
        Destroy(this,2);
    }
}
