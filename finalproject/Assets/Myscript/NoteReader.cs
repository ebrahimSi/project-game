using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteReader : MonoBehaviour
{
    [SerializeField] GameObject Note;
    [SerializeField] GameObject NoteWall;
    [SerializeField] GameObject NoteKey;
    [SerializeField] GameObject NoteWallCamera;
    [SerializeField] GameObject MainCamera;
    [SerializeField] GameObject Fps;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject KillScene;
    private bool CameraWallActive=true;
    [SerializeField] GameObject TextBox;
    private int noteNumber;
    public AudioSource JohnNote;
    public AudioSource JohnNoteWall;
    [SerializeField] GameObject PickUpPanel;
    [SerializeField] GameObject Objectev;
    [SerializeField] GameObject Objectev1;

    // Start is called before the first frame update
    void Start()
    {
        Note.gameObject.SetActive(false);
        NoteWall.gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if (SaveScript.ReadNote == true)
        {
            Note.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
            noteNumber = 1;
            SaveScript.CanShot = false;


        }
        if (SaveScript.ReadNoteWall == true)
        {
            NoteWall.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
            noteNumber = 2;
            SaveScript.CanShot = false;
        }
        if (SaveScript.ReadNoteKey == true)
        {
            NoteKey.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
            noteNumber = 3;
            SaveScript.CanShot = false;
        }
    }
    public void CloseNote()
    {
        SaveScript.ReadNote = false;
        Note.gameObject.SetActive(false);
        SaveScript.ReadNoteWall = false;
        NoteWall.gameObject.SetActive(false);
        SaveScript.ReadNoteKey = false;
        NoteKey.gameObject.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        StartCoroutine(ScenePlayer(noteNumber));
        SaveScript.CanShot = true;
    }

    IEnumerator ScenePlayer(int noteNumber)
    {
        if (noteNumber == 1)
        {
            if (SaveScript.NoteObjectev2 == true)
            {
                yield return new WaitForSeconds(1.5f);

                TextBox.GetComponent<Text>().text = "is this note left by johnathan!?";
                JohnNote.Play();
                yield return new WaitForSeconds(1.5f);
                TextBox.GetComponent<Text>().text = "and..who the hell has the key ? ";
                yield return new WaitForSeconds(1.5f);
                TextBox.GetComponent<Text>().text = "who locked him up ? ";
                yield return new WaitForSeconds(1.5f);
                TextBox.GetComponent<Text>().text = "what the hell is going on here!? ";
                yield return new WaitForSeconds(1.5f);
                TextBox.GetComponent<Text>().text = "";
                Objectev.gameObject.SetActive(true);
                Objectev1.gameObject.SetActive(false);
                SaveScript.Objectev = 4;
                SaveScript.NoteObjectev2 = false;
            }
        }
        else if (noteNumber == 2)
        {
            if (SaveScript.Cinma3==true)
            {

                PickUpPanel.gameObject.SetActive(false);
                Enemy.gameObject.SetActive(true);
                NoteWallCamera.gameObject.SetActive(true);
                MainCamera.gameObject.SetActive(false);
                Fps.gameObject.SetActive(false);
                JohnNoteWall.Play();
                TextBox.GetComponent<Text>().text = "What's this stain of blood ?";
                yield return new WaitForSeconds(2f);
                TextBox.GetComponent<Text>().text = "And again who are they ?!";
                yield return new WaitForSeconds(3.5f);
                TextBox.GetComponent<Text>().text = "What does he mean by everywhere ?";
                yield return new WaitForSeconds(1.5f);
                TextBox.GetComponent<Text>().text = "There is nobody in this town !";
                yield return new WaitForSeconds(2f);
                TextBox.GetComponent<Text>().text = "";
                yield return new WaitForSeconds(3f);
                TextBox.GetComponent<Text>().text = "Hey Wait !!";
                
    yield return new WaitForSeconds(4f);
                NoteWallCamera.gameObject.SetActive(false);
                MainCamera.gameObject.SetActive(true);
                Fps.gameObject.SetActive(true);
                Fps.gameObject.transform.rotation = Quaternion.Euler(-1.5f, -89.1f, 0f);
                MainCamera.gameObject.transform.rotation = Quaternion.Euler(-1.5f, -89.1f, 0f);
                SaveScript.Cinma3 = false;
                Enemy.gameObject.SetActive(false);
                KillScene.gameObject.SetActive(true);
                TextBox.GetComponent<Text>().text = "";
            }
        }


    }
}