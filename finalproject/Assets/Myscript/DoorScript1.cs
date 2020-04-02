using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript1 : MonoBehaviour
{
    [SerializeField] GameObject DoorMessage;
    [SerializeField] GameObject camera;
    [SerializeField] GameObject camera2;
    [SerializeField] GameObject cube;
    [SerializeField] GameObject Fps;


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

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
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
        yield return new WaitForSeconds(17.5f);
        Fps.gameObject.SetActive(true);
       Fps.transform.position = new Vector3(648.574f, 18.77f, 478.6344f);
        yield return new WaitForSeconds(0f);
        camera2.gameObject.SetActive(true);
        camera.gameObject.SetActive(false);
        cube.gameObject.SetActive(true);
      
        this.gameObject.SetActive(false);
    }
}
