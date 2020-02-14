using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] GameObject DoorMessage;
    private Animator Anim;
    private bool CanOpen =false;
    private bool CloOrOP =false;
    // Start is called before the first frame update
    void Start()
    {
        DoorMessage.gameObject.SetActive(false);
        Anim=GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanOpen==true)
{
            if(Input.GetKeyDown(KeyCode.E))
    {
                if(CloOrOP==false){
Anim.SetBool("Open",true);
CloOrOP=true;}
                else{Anim.SetBool("Open",false);
CloOrOP=false;}
    }
}
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("TriggerPlayer"))
{
              DoorMessage.gameObject.SetActive(true);
            CanOpen=true;
}

    }

     private void OnTriggerExit(Collider other)
    {
       if(other.gameObject.CompareTag("TriggerPlayer")){
              DoorMessage.gameObject.SetActive(false);
            CanOpen=false;
}

    }
}
