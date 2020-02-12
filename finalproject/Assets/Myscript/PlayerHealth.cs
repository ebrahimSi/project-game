﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] Text PHText;
    // Start is called before the first frame update
    void Start()
    {
        PHText.text = SaveScript.PlayerHealth + "%";
    }

    // Update is called once per frame
    void Update()
    {
       

        if(SaveScript.DisplayHealth == true)
        {
            SaveScript.DisplayHealth = false;
            PHText.text = SaveScript.PlayerHealth + "%";

        }
    }
}
