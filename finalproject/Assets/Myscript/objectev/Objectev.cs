using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectev : MonoBehaviour
{
    public GameObject Panel;
    public int Number=1;
    void Start() {
        if (Number == 1) {
            if (SaveScript.Objectev1 == false) {

                Destroy(this, 2);
            }
        }

    }
    void OnTriggerEnter(Collider Other) {
        if (Other.gameObject.CompareTag("Player")) {
            Panel.gameObject.SetActive(true);
            SaveScript.Objectev = Number;
            SaveScript.Objectev1 = false;
}
    }
    void OnTriggerExit(Collider Other) {
        Destroy(this,2);
    }
}
