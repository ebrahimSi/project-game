using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBreak : MonoBehaviour
{
    [SerializeField] GameObject FakeVase;
    [SerializeField] GameObject BrokenVase;
    [SerializeField] GameObject HiddenItem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PBat"))
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            
            FakeVase.SetActive(false);
            BrokenVase.SetActive(true);
            HiddenItem.SetActive(true);
        }

    }
}
