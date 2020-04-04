using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageDisplay : MonoBehaviour
{

    [SerializeField] GameObject MessagePanel;
    [SerializeField] GameObject TriggerBox;
    public int Number=0;
    // Start is called before the first frame update
    void Start()
    {
        MessagePanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Number==1){
            if(SaveScript.MassgeTrigg1==true){
            MessagePanel.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
              SaveScript.CanShot=false;
        }}} 
        if(Number==2){
            if(SaveScript.MassgeTrigg2==true){
            MessagePanel.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
              SaveScript.CanShot=false;
        }} 

    if(Number==3){
            if(SaveScript.MassgeTrigg3==true){
            MessagePanel.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
              SaveScript.CanShot=false;
        }}} 


    


    public void ExitMessage()
    {
        MessagePanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        if(Number==1){
        SaveScript.MassgeTrigg1=false;}
         if(Number==2){
        SaveScript.MassgeTrigg2=false;}
          if(Number==3){
        SaveScript.MassgeTrigg3=false;}
        Destroy(TriggerBox, 0.0f);
          SaveScript.CanShot=true;
    }

}
