using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JohnTrig : MonoBehaviour
{
   public GameObject ThePlayer;

    public GameObject camera;
    public GameObject camera2;
    public  GameObject TextBox;
    public AudioSource CallJohnathan;
    public GameObject Objectev;
    public GameObject Objectec1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (SaveScript.Cinma2 == true)
            {
                StartCoroutine(ScenePlayer());
               
            }
            else { Destroy(this); }
        }
    }

   


    IEnumerator ScenePlayer()
    {
        ThePlayer.gameObject.SetActive(false);
        camera.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
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
        ThePlayer.gameObject.SetActive(true);
        ThePlayer.gameObject.transform.position = camera2.gameObject.transform.position;

        yield return new WaitForSeconds(3f);
        camera.gameObject.SetActive(true);
      //  camera.gameObject.transform.rotation = Quaternion.Euler(0f, -49.1f, 0f);
        ThePlayer.gameObject.transform.rotation = Quaternion.Euler(0f, -49.1f, 0f);
        camera2.gameObject.SetActive(false);
        Objectec1.gameObject.SetActive(false);
        Objectev.gameObject.SetActive(true);
        SaveScript.Cinma2 = false;
        SaveScript.Objectev = 3;
        Destroy(this);


    }
}
