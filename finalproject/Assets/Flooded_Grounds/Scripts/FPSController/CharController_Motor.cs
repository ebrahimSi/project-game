using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CharController_Motor : MonoBehaviour
{

    public float speed = 10.0f;

    public float WalkSpeed = 7.0f;
    public float RunSpeed = 12.0f;

    public float sensitivity = 30.0f;
    public float WaterHeight = 15.5f;
    CharacterController character;
    private GameObject cam;

    public GameObject cam1;
     public GameObject camNight;
    private NavMeshAgent nav;
    private bool AIActive = true;

    // public bool NighVision = false;

    float moveFB, moveLR;
    float rotX, rotY;
   
    float gravity = -9.8f;
    public float Stamina = 10f;
    public float MaxStamina = 10f;
    public int DecayRate = 1;
    public float RefillRate = 0.25f;


    public GameObject LightBreathing;
    public GameObject HeavyBreathing;
    private bool LightBreath = false;
    private bool HeavyBreath = false;
    public GameObject LowHealthSound;
    public GameObject LowHealthPanel;
    public GameObject PlayerDeath;
    public  GameObject TextBox;
     public  GameObject Chapter;
     public AudioSource CallJohnathan;



    void Start()
    {
     
        //LockCursor ();
        character = GetComponent<CharacterController>();
      
            sensitivity = sensitivity * 1.5f;
            Cursor.visible = false;
            speed = WalkSpeed;
            cam = cam1;
            if(PlayerPrefs.GetInt("Cinma1") == 0){
             camNight.gameObject.SetActive(true);
          cam.gameObject.SetActive(false);
            StartCoroutine(WaitForcinma());
       // cam.gameObject.SetActive(true);
SaveScript.Cinma1=false;}
else{cam.gameObject.SetActive(true);}
            LightBreathing.gameObject.SetActive(false);
            HeavyBreathing.gameObject.SetActive(false);
            nav = GetComponent<NavMeshAgent>();
            AIActive = true;
            LowHealthSound.gameObject.SetActive(false);
            PlayerDeath.gameObject.SetActive(false);

       
    }


    void CheckForWaterHeight()
    {
        if (transform.position.y < WaterHeight)
        {
            gravity = 0f;
        }
        else
        {
            gravity = -9.8f;
        }
    }



    void Update()
    {

        if (LightBreath == false)
        {
            if (Stamina < 3)
            {
                LightBreathing.gameObject.SetActive(true);
                HeavyBreathing.gameObject.SetActive(false);
                LightBreath = true;
            }
        }


        if (LightBreath == true)
        {
            if (Stamina > 3)
            {
                LightBreathing.gameObject.SetActive(false);
                HeavyBreathing.gameObject.SetActive(false);
                LightBreath = false;
            }
        }


        if (HeavyBreath == false)
        {
            if (Stamina == 0)
            {
                LightBreathing.gameObject.SetActive(false);
                HeavyBreathing.gameObject.SetActive(true);
                HeavyBreath = true;
            }
        }


        if (HeavyBreath == true)
        {
            if (Stamina > 0)
            {
                LightBreathing.gameObject.SetActive(false);
                HeavyBreathing.gameObject.SetActive(false);
                HeavyBreath = false;
            }
        }



        if (Stamina > 0)
        {


            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = RunSpeed;
                Stamina = Stamina - DecayRate * Time.deltaTime;
                if (Stamina < 0)
                {
                    Stamina = 0;
                }
            }
            else
            {
                speed = WalkSpeed;
                Stamina = Stamina + RefillRate * Time.deltaTime;
                if (Stamina > MaxStamina)
                {
                    Stamina = MaxStamina;
                }
            }
        }


        if (Stamina == 0)
        {
            speed = WalkSpeed;
            StartCoroutine(StaminaRefill());
        }






        if (SaveScript.PlayerHealth < 5)
        {
            LowHealthSound.gameObject.SetActive(true);
            LowHealthPanel.gameObject.SetActive(true);

        }

        if (SaveScript.PlayerHealth > 4)
        {
            LowHealthSound.gameObject.SetActive(false);
            LowHealthPanel.gameObject.SetActive(false);

        }

        if (SaveScript.PlayerHealth <= 0)
        {
            PlayerDeath.gameObject.SetActive(true);
            StartCoroutine(WaitForMain());
            SceneManager.LoadScene(0);
        }





        if (AIActive == true)
        {
            nav.enabled = true;
        }
        else
        {
            nav.enabled = false;
        }

        if (SaveScript.NighVision == false)
        {
            cam = cam1;
            //   camNight.gameObject.SetActive(false);
            SaveScript.NighVision = false;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            if (SaveScript.NighVision == false)
            {
                //   camNight.gameObject.SetActive(true);
                //  cam = camNight;
                SaveScript.NighVision = true;
            }

            else
            {
                cam = cam1;
                //    camNight.gameObject.SetActive(false);
                SaveScript.NighVision = false;
            }
        }

        moveFB = Input.GetAxis("Horizontal") * speed;
        moveLR = Input.GetAxis("Vertical") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity;

        //rotX = Input.GetKey (KeyCode.Joystick1Button4);
        //rotY = Input.GetKey (KeyCode.Joystick1Button5);

        CheckForWaterHeight();


      Vector3 movement = new Vector3(moveFB, gravity, moveLR);
       //character.velocity = Vector3.zero;
        if (WalkSpeed==0&&RunSpeed==0) {
            nav.enabled = false;
        }

        
          CameraRotation(cam, rotX, rotY);
        movement = transform.rotation * movement;
        character.Move(movement * Time.deltaTime);
    }


    void CameraRotation(GameObject cam, float rotX, float rotY)
    {
        transform.Rotate(0, rotX * Time.deltaTime, 0);
        cam.transform.Rotate(-rotY * Time.deltaTime, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            AIActive = false;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            AIActive = true;
        }
    }


    IEnumerator StaminaRefill()
    {
        yield return new WaitForSeconds(MaxStamina);
        if (Stamina == 0)
        {
            Stamina = MaxStamina;
        }
    }

    IEnumerator WaitForMain()
    {
        yield return new WaitForSeconds(15f);
    }
      IEnumerator WaitForcinma()
    {
        yield return new WaitForSeconds(1.9f);
        TextBox.GetComponent<Text>().text = "";
         yield return new WaitForSeconds(1.9f);
     
        TextBox.GetComponent<Text>().text = "";
         CallJohnathan.Play();
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text = "My Head !";
        yield return new WaitForSeconds(2.25f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2.2f);
        TextBox.GetComponent<Text>().text = "Where Am I ?!?";
         yield return new WaitForSeconds(2.25f);
        TextBox.GetComponent<Text>().text = "";
        Chapter.gameObject.SetActive(true);
       yield return new WaitForSeconds(2.25f);
        Chapter.gameObject.SetActive(false);
        cam.gameObject.SetActive(true);
        camNight.gameObject.SetActive(false);
    }
}
