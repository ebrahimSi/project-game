using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JohnTrig : MonoBehaviour
{
   public GameObject ThePlayer;
    
  public  GameObject TextBox;
    public AudioSource CallJohnathan;


   void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ScenePlayer());
    }

   


    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
      
        TextBox.GetComponent<Text>().text = "johnathan !!";
        CallJohnathan.Play();
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "johnathan, where are you ?!!";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "Answer me !!";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = "Where the hell did he go ?";

        TextBox.GetComponent<Text>().text = "";
        Destroy(this);


    }
}
