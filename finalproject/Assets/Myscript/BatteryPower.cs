using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPower : MonoBehaviour
{

    [SerializeField] Image BatteryUI;
    [SerializeField] float DrainTime = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Refill()
    {
        BatteryUI.fillAmount = 1f;
        SaveScript.Batteries -= 1;
    }



    // Update is called once per frame
    void Update()
    {
        if (SaveScript.FlashlightOn == true)
        {
            BatteryUI.fillAmount -= 1.0f / DrainTime * Time.deltaTime;
            SaveScript.BatteryPower = BatteryUI.fillAmount;
            if(SaveScript.BatteryPower == 0)
            {
                SaveScript.FlashlightOn = false;
            }
        }

        if (SaveScript.NighVision == true)
        {
            BatteryUI.fillAmount -= 1.0f / DrainTime * Time.deltaTime;
            SaveScript.BatteryPower = BatteryUI.fillAmount;
            if (SaveScript.BatteryPower == 0)
            {
                SaveScript.NighVision = false;
            }
        }
    }
}
