using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageDisplay : MonoBehaviour
{

    [SerializeField] GameObject MessagePanel;
    [SerializeField] GameObject TriggerBox;
    // Start is called before the first frame update
    void Start()
    {
        MessagePanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MessagePanel.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;

        }
    }


    public void ExitMessage()
    {
        MessagePanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        Destroy(TriggerBox, 0.0f);
    }

}
