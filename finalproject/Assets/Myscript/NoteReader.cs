using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteReader : MonoBehaviour
{
    [SerializeField] GameObject Note;
    [SerializeField] GameObject NoteWall;


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

            NoteWall.gameObject.SetActive(true);
            Cursor.visible = true;
        }
    }
    public void CloseNote()
    {
        SaveScript.ReadNote = false;
        Note.gameObject.SetActive(false);

        Note.gameObject.SetActive(false);
        Cursor.visible = true;
    }
}