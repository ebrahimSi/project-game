using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JohnTrig1 : MonoBehaviour
{
    public GameObject ThePlayer;

    public GameObject camera;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject TextBox;
    public AudioSource CallJohnathan;
    [SerializeField] GameObject Objectev7;
    [SerializeField] GameObject Objectev8;


    void Start() {
        
        }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (SaveScript.Cinmajohn == true)
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

        TextBox.GetComponent<Text>().text = " ";
      
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "Johnathan are you okay !?";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = "Yeah i'm okay";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = "  ";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = " Thank god !";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = " Okay we need to get out of here";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = " i think i saw a bout near the church";
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = "";
        // ThePlayer.gameObject.SetActive(true);
        //  ThePlayer.gameObject.transform.position = camera2.gameObject.transform.position;

        yield return new WaitForSeconds(0f);
        // camera.gameObject.SetActive(true);
        //  camera.gameObject.transform.rotation = Quaternion.Euler(0f, -49.1f, 0f);
        //ThePlayer.gameObject.transform.rotation = Quaternion.Euler(0f, -49.1f, 0f);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(true);
        yield return new WaitForSeconds(27f);
        camera3.gameObject.SetActive(false);
        ThePlayer.gameObject.SetActive(true);
        camera.gameObject.SetActive(true);
        Objectev7.gameObject.SetActive(false);
        Objectev8.gameObject.SetActive(true);
        SaveScript.Cinmajohn = false;
        Destroy(this);


    }
}
