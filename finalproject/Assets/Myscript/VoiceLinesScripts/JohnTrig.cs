using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JohnTrig : MonoBehaviour
{
   public GameObject ThePlayer;
    
  public  GameObject TextBox;


   void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ScenePlayer());
    }

   


    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
      
        TextBox.GetComponent<Text>().text = "johnathan !!";
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "johnathaaaaan !!";
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "";
         Destroy(TextBox);


    }
}
