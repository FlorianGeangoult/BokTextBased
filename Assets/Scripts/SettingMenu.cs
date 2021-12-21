using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public Dropdown Reschoix;

    Resolution[] resolutions;

    void Start()
    {

       resolutions = Screen.resolutions;

        Reschoix.ClearOptions();


        List<string> options = new List<string>();

        int IndicResActuel = 0;
        for(int i = 0; i <resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                IndicResActuel = i;
            }
        }

        Reschoix.AddOptions(options);
        Reschoix.value = IndicResActuel;
        Reschoix.RefreshShownValue();
    }


    public void DefRes(int IndiceRes)
    {
        Resolution resolution = resolutions[IndiceRes];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void DefSon (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void DefQualité(int IndicQualité)
    {
        QualitySettings.SetQualityLevel(IndicQualité);
    }

    public void DefFullscreen(bool FullscreenOn)
    {
        Screen.fullScreen = FullscreenOn;
    }
}
