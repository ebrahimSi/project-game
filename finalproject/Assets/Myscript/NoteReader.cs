using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteReader : MonoBehaviour
{
    [SerializeField] GameObject Note;
    [SerializeField] GameObject NoteWall;
    [SerializeField] GameObject TextBox;
    private int noteNumber;
    public AudioSource JohnNote;


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
            noteNumber = 1;
          


        }
        if (SaveScript.ReadNoteWall == true)
        {
            NoteWall.gameObject.SetActive(true);
            Cursor.visible = true;
            noteNumber = 2;
            
        }
    }
    public void CloseNote()
    {
        SaveScript.ReadNote = false;
        Note.gameObject.SetActive(false);
        SaveScript.ReadNoteWall = false;
        NoteWall.gameObject.SetActive(false);
        Cursor.visible = true;
        StartCoroutine(ScenePlayer(noteNumber));
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
            yield return new WaitForSeconds(1.5f);

            TextBox.GetComponent<Text>().text = "this is noteWall !!";
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = "NoteWall !!";
            yield return new WaitForSeconds(1.5f);
            TextBox.GetComponent<Text>().text = "";
        }


    }
}