using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigGreen : MonoBehaviour
{
     Animator cAnim;
    Animator bAnim;
    AudioSource aSource;
    AudioSource bSource;
    AudioSource cSource;
    AudioSource dSource;
    Vector3 camPos;
    public Transform gPointer;
    public Transform gLock;
    public Transform gLockpick;
    public Transform gCam;
    public GameObject mPlayer;
    public GameObject lockPick;
    public DoorTrigger DoorTrigger;
    public Image uiTextureLockpickBroke;
    public Image uiTextureLockPin;
    public float blockTime;
    public float cameraShakeTime;
    public float textureStartTime;
    public float textureEndTime;
    public float shakeMlt;
    public float PointerSpeed;

    float T;
    float T2;
    float T3;
    float T4;
    bool hasEntered;
    bool blockPress;
    bool stopBall;
    bool cameraShake;
    bool showTexture;
    int animState;

    void Start()
    {
        cAnim = gLock.GetComponent<Animator>();
        bAnim = gPointer.GetComponent<Animator>();
        aSource = gPointer.GetComponent<AudioSource>();
        bSource = gLock.GetComponent<AudioSource>();
        cSource = gLockpick.GetComponent<AudioSource>();
        dSource = gCam.GetComponent<AudioSource>();

        camPos = Camera.main.transform.position;
        bAnim.speed = PointerSpeed;

        uiTextureLockPin.gameObject.SetActive(true);

    }





    void OnTriggerEnter(Collider gPointer)
    {

            hasEntered = true;
       
    }

    void OnTriggerExit(Collider gPointer)
    {
       
            hasEntered = true;
     
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))

        {

            stopBall = true;
            blockPress = true;
            cAnim.SetInteger("State", animState = 0);
            Invoke("Switcher", 2f);

        }




        if (Input.GetKeyDown(KeyCode.E))
        {
            
            stopBall = true;
            if (hasEntered)
            {
                if (bAnim.speed == PointerSpeed)
                {
                    bSource.Play();
                    cSource.Play();
                    cAnim.SetInteger("State", animState += 1);
                    blockPress = true;
                    if (animState == 4)
                    {
                        dSource.Play();
                        Invoke("Switcher", 2f);
                        DoorTrigger.isCracked = true;




                    }
                }
            }
            else
            {
                aSource.Play();
                cameraShake = true;
                showTexture = true;
                cAnim.SetInteger("State", animState = 0);
              
            }
        }

        if (stopBall)
        {
            T2 += Time.deltaTime;
            bAnim.speed = 0;
            if (T2 >= blockTime)
            {
                bAnim.speed = PointerSpeed;
                stopBall = false;
                T2 = 0;
            }

        }






        if (cameraShake)
        {
            T3 += Time.deltaTime;
            Camera.main.transform.position = camPos + Random.onUnitSphere * shakeMlt / 10f;
            if (T3 >= cameraShakeTime)
            {
                cameraShake = false;
                T3 = 0;
                Camera.main.transform.position = camPos;
            }
        }

        if (showTexture)
        {
            T4 += Time.deltaTime;
            if (T4 >= textureStartTime)
            {
                uiTextureLockpickBroke.gameObject.SetActive(true);
                lockPick.SetActive(false);
            }
            if (T4 >= textureEndTime)
            {
                mPlayer.GetComponent<Inventar>()._lpCount -= 1;
                lockPick.SetActive(true);
                showTexture = false;
                uiTextureLockpickBroke.gameObject.SetActive(false);
                T4 = 0;
                if (mPlayer.GetComponent<Inventar>()._lpCount == 0)
                    Invoke("Switcher", 0f);




            }
        }
    }

    void Switcher()
    {
        transform.parent.gameObject.SetActive(false);
        mPlayer.SetActive(true);
        uiTextureLockPin.gameObject.SetActive(false);
    }


}