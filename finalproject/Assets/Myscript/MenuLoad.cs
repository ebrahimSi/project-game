using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.PostProcessing;
public class MenuLoad : MonoBehaviour
{
    public PostProcessingProfile Default;
   // public PostProcessingProfile NightVision;
    // Start is called before the first frame update
    void Start()
    {
        Default.antialiasing.enabled = true;
        //NightVision.antialiasing.enabled = true;
        Default.ambientOcclusion.enabled = true;
    //    NightVision.ambientOcclusion.enabled = true;
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {

    }
}