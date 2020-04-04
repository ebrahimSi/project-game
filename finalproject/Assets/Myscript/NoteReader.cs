using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteReader : MonoBehaviour
{
    [SerializeField] GameObject Note;
    [SerializeField] GameObject NoteWall;
    [SerializeField] GameObject NoteWallCamera;
    [SerializeField] GameObject MainCamera;
    [SerializeField] GameObject Fps;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject Enemy1;
    [SerializeField] GameObject Enemy2;
    [SerializeField] GameObject Enemy3;
    private bool CameraWallActive=true;
    [SerializeField] GameObject TextBox;
    private int noteNumber;
    public AudioSource JohnNote;
    public AudioSource JohnNoteWall;

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
    }
    public void CloseNote()
    {
        SaveScript.ReadNote = false;
        Note.gameObject.SetActive(false);
        SaveScript.ReadNoteWall = false;
        NoteWall.gameObject.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        StartCoroutine(ScenePlayer(noteNumber));
        SaveScript.CanShot = true;
    }

    IEnumerator ScenePlayer(int noteNumber)
    {
        if (noteNumber == 1)
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
        }
        else if (noteNumber == 2)
        {
            if (SaveScript.Cinma3==true)
            {
                Enemy.gameObject.SetActive(true);
                NoteWallCamera.gameObject.SetActive(true);
                MainCamera.gameObject.SetActive(false);
                Fps.gameObject.SetActive(false);
                yield return new WaitForSeconds(7.5f);
                TextBox.GetComponent<Text>().text = "hay come";
                 JohnNoteWall.Play();
    yield return new WaitForSeconds(1f);
                NoteWallCamera.gameObject.SetActive(false);
                MainCamera.gameObject.SetActive(true);
                Fps.gameObject.SetActive(true);
                Fps.gameObject.transform.rotation = Quaternion.Euler(-1.5f, -89.1f, 0f);
                MainCamera.gameObject.transform.rotation = Quaternion.Euler(-1.5f, -89.1f, 0f);
                SaveScript.Cinma3 = false;
                Enemy.gameObject.SetActive(false);
                Enemy1.gameObject.SetActive(true);
                Enemy2.gameObject.SetActive(true);
                Enemy3.gameObject.SetActive(true);
                TextBox.GetComponent<Text>().text = "";
            }
        }


    }
}