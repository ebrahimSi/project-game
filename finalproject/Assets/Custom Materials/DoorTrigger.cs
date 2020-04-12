using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTrigger : MonoBehaviour
{
    Animator dAnim;
    AudioSource aSource;
    AudioSource bSource;
    public GameObject LockPrefab;
    public GameObject Adoor;
    public GameObject Adoorframe;
    public GameObject mPlayer;
    public GameObject statusPicture;
    public GameObject statusPictureHard;
    public GameObject GreenEsey;
    public GameObject GreenEseyCube;
    public GameObject GreenHard;
    public GameObject GreenHardCube;
    public Image uiTextureLockPin;
    public Image uiTextureUnlocked;
    public bool isCracked;
    bool hasEntered;
    bool dStatus;

    void Start()
    {
        dAnim = transform.parent.GetComponent<Animator>();
        aSource = Adoor.GetComponent<AudioSource>();
        bSource = Adoorframe.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasEntered = true;
            if (!isCracked)
            {
                if (SaveScript.Difficulty == 0.5f)
                {
                    statusPicture.SetActive(true);
                }
                if (SaveScript.Difficulty == 1.5f)
                {
                    statusPictureHard.SetActive(true);
                }
            }
            else
            {
                uiTextureUnlocked.gameObject.SetActive(true);
            }
        }
    }





    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasEntered = false;
            statusPicture.SetActive(false);
            statusPictureHard.SetActive(false);

            uiTextureUnlocked.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (hasEntered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!isCracked)
                {
                    if (mPlayer.GetComponent<Inventar>()._lpCount > 0)
                    {

                        if (SaveScript.Difficulty == 0.5f)
                        {
                            GreenEsey.SetActive(true);
                            GreenEseyCube.SetActive(true);
                            GreenHard.SetActive(false);
                            GreenHardCube.SetActive(false);
                        }
                        if (SaveScript.Difficulty == 1.5f)
                        {
                            GreenHard.SetActive(true);
                            GreenHardCube.SetActive(true);
                            GreenEsey.SetActive(false);
                            GreenEseyCube.SetActive(false);
                        }
                        aSource.Play();
                        LockPrefab.SetActive(true);
                        mPlayer.SetActive(false);
                        statusPicture.SetActive(false);
                        uiTextureLockPin.gameObject.SetActive(true);

                    }
                }
                else
                {
                    bSource.Play();
                    dStatus = !dStatus;
                    dAnim.SetBool("Status", dStatus);
                    uiTextureUnlocked.gameObject.SetActive(true);
                }
            }
        }
    }
}