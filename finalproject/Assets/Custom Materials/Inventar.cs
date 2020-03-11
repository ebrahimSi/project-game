using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
     public Image uiTexture;
    public Text lpCountText;
    int lpCount = 3;

    void Start()
    {

        uiTexture.gameObject.SetActive(true);
    }


    public int _lpCount
    {
        get { return lpCount; }
        set
        {
            lpCount = value;
            lpCountText.text = "" + lpCount.ToString();
        }
    }
}