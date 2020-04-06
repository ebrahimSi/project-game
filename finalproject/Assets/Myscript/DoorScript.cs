using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    [SerializeField] GameObject DoorMessage;
    public AudioSource DoorSound;
     [SerializeField] bool Locked;
      [SerializeField] bool Cinma;
    private Animator Anim;
    private bool CanOpen =false;
    private bool CloOrOP =false;
    public int Numberkey=10;
    [SerializeField] Text MassageText;
    // Start is called before the first frame update
    void Start()
    {
        DoorMessage.gameObject.SetActive(false);
        Anim=GetComponentInParent<Animator>();
        if(Cinma==false){
Anim.SetBool("Skip",true);
}
    }

    // Update is called once per frame
    void Update()
    {
        if(Locked==false){
        if(CanOpen==true)
{
            if(Input.GetKeyDown(KeyCode.E))
    {
                if(CloOrOP==false){
Anim.SetBool("Open",true);
CloOrOP=true;
 DoorSound.Play();}
                else{Anim.SetBool("Open",false);
CloOrOP=false;
DoorSound.Play();}
    }
}
}else  MassageText.text="closed";
        if(Locked==true){
            if(Numberkey==0){
if(SaveScript.HaveKey==true){
Locked=false;
                MassageText.text="Unlocked -press E to Open";
}
}
             if(Numberkey==1){
if(SaveScript.HaveKey2==true){
Locked=false;
                MassageText.text="Unlocked -press E to Open";
}
}
              if(Numberkey==2){
if(SaveScript.HaveKey3==true){
Locked=false;
                MassageText.text="Unlocked -press E to Open";
}
}
             
}

    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
{
              DoorMessage.gameObject.SetActive(true);
            CanOpen=true;
}

    }

     private void OnTriggerExit(Collider other)
    {
       if(other.gameObject.CompareTag("Player")){
              DoorMessage.gameObject.SetActive(false);
            CanOpen=false;
}

    }
}
