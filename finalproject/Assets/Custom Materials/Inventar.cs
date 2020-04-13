using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
     public Image uiTexture;
    public Text lpCountText;
   
    int lpCount = 0;

    void Start()
    {

        uiTexture.gameObject.SetActive(true);
    }

    void Update()
    {

if(lpCount==0){
        uiTexture.gameObject.SetActive(false);
        lpCountText.gameObject.SetActive(false);
        }else{
 uiTexture.gameObject.SetActive(true);
        lpCountText.gameObject.SetActive(true);
}
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