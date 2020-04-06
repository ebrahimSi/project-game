using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript2 : MonoBehaviour
{
    [SerializeField] GameObject DoorMessage;
    [SerializeField] GameObject camera;
    [SerializeField] GameObject camera2;
    [SerializeField] GameObject cube;
    [SerializeField] GameObject Fps;
    public GameObject TextBox;
    public AudioSource CallJohnathan;

    public int Numberkey = 10;
    public AudioSource DoorSound;
     [SerializeField] bool Locked;
    private Animator Anim;
    private bool CanOpen =false;
    private bool CloOrOP =false;
    [SerializeField] Text MassageText;
    // Start is called before the first frame update
    void Start()
    {
        DoorMessage.gameObject.SetActive(false);
        Anim=GetComponentInParent<Animator>(); 
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Locked == false)
        {
            if (CanOpen == true)
            {

                if (Input.GetKeyDown(KeyCode.E))
                {

                    Anim.SetBool("Open2", true);
                    DoorSound.Play();
                    Fps.gameObject.SetActive(false);
                    camera2.gameObject.SetActive(false);
                    camera.gameObject.SetActive(true);
                    StartCoroutine(WaitForMain());


                }
            }
        }
        else MassageText.text = "closed";
        if (Locked == true)
        {
            if (Numberkey == 0)
            {
                if (SaveScript.HaveKey == true)
                {
                    Locked = false;
                    MassageText.text = "Unlocked -press E to Open";
                }
            }
            if (Numberkey == 1)
            {
                if (SaveScript.HaveKey2 == true)
                {
                    Locked = false;
                    MassageText.text = "Unlocked -press E to Open";
                }
            }
            if (Numberkey == 2)
            {
                if (SaveScript.HaveKey3 == true)
                {
                    Locked = false;
                    MassageText.text = "Unlocked -press E to Open";
                }
            }

        }




    }

    private void OnTriggerEnter(Collider other)
    {

        if (SaveScript.Cinma5 == false)
        {
            Anim.SetBool("Skip", true);
            cube.gameObject.SetActive(true);

            this.gameObject.SetActive(false);
        }else
        if (other.gameObject.CompareTag("Player"))
{
              DoorMessage.gameObject.SetActive(true);
            CanOpen = true;

        }

    }

     private void OnTriggerExit(Collider other)
    {
       if(other.gameObject.CompareTag("Player")){
              DoorMessage.gameObject.SetActive(false);
            CanOpen = false;

        }
       

    }
    IEnumerator WaitForMain()
    {

        yield return new WaitForSeconds(3f);

        TextBox.GetComponent<Text>().text = "johnathan !!";
        CallJohnathan.Play();
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "johnathan, where are you ?!!";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "oh here you are ?";
        yield return new WaitForSeconds(3.14f);
        TextBox.GetComponent<Text>().text = "i found you";

        TextBox.GetComponent<Text>().text = "";
        //
      //  yield return new WaitForSeconds(17.5f);
        Fps.gameObject.SetActive(true);
       Fps.transform.position = new Vector3(542.2999f, 21.889f, 381.4213f);

        yield return new WaitForSeconds(0f);
        camera2.gameObject.SetActive(true);
        //camera.gameObject.SetActive(false);
        cube.gameObject.SetActive(true);
        SaveScript.Cinma5 = false;
        this.gameObject.SetActive(false);
    }
}
