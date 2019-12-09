using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryManager : MonoBehaviour
{

    [SerializeField] GameObject BatteryImage1;
    [SerializeField] GameObject BatteryImage2;
    [SerializeField] GameObject BatteryImage3;
    [SerializeField] GameObject BatteryButton1;
    [SerializeField] GameObject BatteryButton2;
    [SerializeField] GameObject BatteryButton3;


    // Start is called before the first frame update
    void Start()
    {
        SaveScript.BatteryClick = true;

    }

    // Update is called once per frame
    void Update()
    {
        CheckBatteries();
    }

    void CheckBatteries()
    {
        if(SaveScript.BatteryClick == true)
        {
            if(SaveScript.Batteries == 0)
            {
                BatteryImage1.gameObject.SetActive(false);
                BatteryImage2.gameObject.SetActive(false);
                BatteryImage3.gameObject.SetActive(false);
                BatteryButton1.gameObject.SetActive(false);
                BatteryButton2.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(false);


            }

            if (SaveScript.Batteries == 1)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(false);
                BatteryImage3.gameObject.SetActive(false);
                BatteryButton1.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(false);


            }

            if (SaveScript.Batteries == 2)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(false);
                BatteryButton1.gameObject.SetActive(false);
                BatteryButton2.gameObject.SetActive(true);
                BatteryButton3.gameObject.SetActive(false);


            }

            if (SaveScript.Batteries == 3)
            {
                BatteryImage1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(true);
                BatteryButton1.gameObject.SetActive(false);
                BatteryButton2.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(true);


            }
        }
    }
}
