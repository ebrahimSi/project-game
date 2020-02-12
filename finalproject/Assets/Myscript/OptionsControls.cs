using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;
using UnityEngine.Audio;
public class OptionsControls : MonoBehaviour
{
    public Slider LightSlider;
    public GameObject FogParticles;
    private bool FogActive = true;
    public PostProcessingProfile Default;
   // public PostProcessingProfile NightVision;
    private bool AntiOn = true;
    public Slider VolumeLevel;
    public AudioMixer MasterVolume;
    public void Lighting()
    {
        RenderSettings.ambientIntensity = LightSlider.value;
    }
    public void Fog()
    {
        if (FogActive == true)
        {
            RenderSettings.fog = false;
        }
        else if (FogActive == false)
        {
            RenderSettings.fog = true;
        }
        FogOn();
    }
    public void AntiAliasing()
    {
        if (AntiOn == true)
        {
            Default.antialiasing.enabled = false;
           // NightVision.antialiasing.enabled = false;
            Default.ambientOcclusion.enabled = false;
          //  NightVision.ambientOcclusion.enabled = false;
            AntiOn = false;
        }
        else if (AntiOn == false)
        {
            Default.antialiasing.enabled = true;
           // NightVision.antialiasing.enabled = true;
            Default.ambientOcclusion.enabled = true;
         //   NightVision.ambientOcclusion.enabled = true;
            AntiOn = true;
        }
    }
    public void Volume()
    {
        MasterVolume.SetFloat("Volume", VolumeLevel.value);
    }
    public void DifficultyEasy()
    {
        SaveScript.Difficulty = 0.5f;
    }
    public void DifficultyMedium()
    {
        SaveScript.Difficulty = 1.0f; 
    }
    public void DifficultyHard()
    {
       SaveScript.Difficulty = 1.5f;
    }
    void FogOn()
    {
        if (FogActive == true)
        {
            FogParticles.gameObject.SetActive(false);
            FogActive = false;
        }
        else if (FogActive == false)
        {
            FogParticles.gameObject.SetActive(true);
            FogActive = true;
        }
    }
}