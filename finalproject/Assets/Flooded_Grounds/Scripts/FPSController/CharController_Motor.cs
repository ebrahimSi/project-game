using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharController_Motor : MonoBehaviour {

	private float speed = 10.0f;

    public float WalkSpeed = 7.0f;
    public float RunSpeed = 12.0f;

	public float sensitivity = 30.0f;
	public float WaterHeight = 15.5f;
	CharacterController character;
	private GameObject cam;

    public GameObject cam1;
   // public GameObject camNight;
    private NavMeshAgent nav;
    private bool AIActive = true;

   // public bool NighVision = false;

    float moveFB, moveLR;
	float rotX, rotY;
	public bool webGLRightClickRotation = true;
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

    public GameObject PlayerDeath;




    void Start(){
		//LockCursor ();
		character = GetComponent<CharacterController> ();
		if (Application.isEditor) {
			webGLRightClickRotation = false;
			sensitivity = sensitivity * 1.5f;
            Cursor.visible = false;
            speed = WalkSpeed;
            cam = cam1;
        //    camNight.gameObject.SetActive(false);
            LightBreathing.gameObject.SetActive(false);
            HeavyBreathing.gameObject.SetActive(false);
            nav = GetComponent<NavMeshAgent>();
            AIActive = true;
            LowHealthSound.gameObject.SetActive(false);
            PlayerDeath.gameObject.SetActive(false);

        }
    }


	void CheckForWaterHeight(){
		if (transform.position.y < WaterHeight) {
			gravity = 0f;			
		} else {
			gravity = -9.8f;
		}
	}



	void Update(){

        if(LightBreath == false)
        {
            if(Stamina < 3)
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



        if(Stamina > 0)
        {

       
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = RunSpeed;
                Stamina = Stamina - DecayRate * Time.deltaTime;
                if(Stamina < 0)
                {
                    Stamina = 0;
                }
        }
        else
        {
            speed = WalkSpeed;
                Stamina = Stamina + RefillRate * Time.deltaTime;
                if(Stamina > MaxStamina)
                {
                    Stamina = MaxStamina;
                }
            }
        }


        if(Stamina == 0)
        {
            speed = WalkSpeed;
            StartCoroutine(StaminaRefill());
        }






        if(SaveScript.PlayerHealth < 5)
        {
            LowHealthSound.gameObject.SetActive(true);

        }

        if (SaveScript.PlayerHealth > 4)
        {
            LowHealthSound.gameObject.SetActive(false);

        }

        if(SaveScript.PlayerHealth <= 0)
        {
            PlayerDeath.gameObject.SetActive(true);

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
            if(SaveScript.NighVision == false)
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

		moveFB = Input.GetAxis ("Horizontal") * speed;
		moveLR = Input.GetAxis ("Vertical") * speed;

		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		//rotX = Input.GetKey (KeyCode.Joystick1Button4);
		//rotY = Input.GetKey (KeyCode.Joystick1Button5);

		CheckForWaterHeight ();


		Vector3 movement = new Vector3 (moveFB, gravity, moveLR);



		if (webGLRightClickRotation) {
			if (Input.GetKey (KeyCode.Mouse0)) {
				CameraRotation (cam, rotX, rotY);
			}
		} else if (!webGLRightClickRotation) {
			CameraRotation (cam, rotX, rotY);
		}

		movement = transform.rotation * movement;
		character.Move (movement * Time.deltaTime);
	}


	void CameraRotation(GameObject cam, float rotX, float rotY){		
		transform.Rotate (0, rotX * Time.deltaTime, 0);
		cam.transform.Rotate (-rotY * Time.deltaTime, 0, 0);
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
        if(Stamina == 0)
        {
            Stamina = MaxStamina;
        }
    }


}
