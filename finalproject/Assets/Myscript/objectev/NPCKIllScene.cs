using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCKIllScene : MonoBehaviour
{
    [SerializeField] GameObject Killer;
    [SerializeField] GameObject NPC;
    [SerializeField] GameObject CameraMain;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Camera;
    [SerializeField] GameObject Camera2;
    [SerializeField] GameObject Camera3;
    [SerializeField] GameObject NaveCube;
    [SerializeField] GameObject TextBox;
    [SerializeField] AudioSource sound;
    [SerializeField] GameObject Objectev6;
    [SerializeField] GameObject Objectev7;
    private Animator animKiller;
    private Animator animNPC;
    private bool  Scene=true;
    [SerializeField] GameObject truekiller;
    // Start is called before the first frame update
    void Start()
    {
        animKiller = Killer.GetComponent<Animator>();
        animNPC = NPC.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider Other) {
        if (Other.gameObject.CompareTag("Player"))
        {
            if (Scene == true)
            {
                StartCoroutine(SceneKill());
                Scene = false;
            }
        }
    }
    IEnumerator SceneKill()
    {
        Camera.gameObject.SetActive(true);
        Player.gameObject.SetActive(false);
        Player.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        Camera2.gameObject.SetActive(true);
        Camera.gameObject.SetActive(false);
        animKiller.SetBool("Attack",true);

        animNPC.SetBool("Die", true);
        yield return new WaitForSeconds(0f);
        animKiller.SetBool("Attack", false);
        yield return new WaitForSeconds(2.5f);
        Camera3.gameObject.SetActive(true);
        Camera2.gameObject.SetActive(false);
        animKiller.SetBool("Move", true);
        yield return new WaitForSeconds(1.5f);
        NaveCube.gameObject.SetActive(true);
        yield return new WaitForSeconds(6f);
        Camera3.gameObject.SetActive(false);
        NaveCube.gameObject.SetActive(true);
        Player.gameObject.SetActive(true);
        CameraMain.gameObject.SetActive(true);
        truekiller.gameObject.SetActive(true);
        Killer.gameObject.SetActive(false);
        SaveScript.CinmaKillScene = false;
        sound.Play();
       
        TextBox.GetComponent<Text>().text = "What is going on here ?!";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        Objectev6.gameObject.SetActive(false);
        Objectev7.gameObject.SetActive(true);
        SaveScript.Objectev = 7;

    }
    }
