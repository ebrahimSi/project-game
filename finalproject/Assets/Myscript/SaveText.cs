using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveText : MonoBehaviour
{
    [SerializeField] Text SavedText;
    // Start is called before the first frame update
    void Start()
    {
        SavedText.text = "Press S to save";
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SavedText.text = "Save successful";
            StartCoroutine(MessageWait());
        }
    }
    IEnumerator MessageWait()
    {
        yield return new WaitForSeconds(1f);
        SavedText.text = "Press S to save";
    }
}