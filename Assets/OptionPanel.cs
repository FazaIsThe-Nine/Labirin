using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class OptionPanel : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] Toggle mutetoggle;

    private void OnEnable() 
    {
        mutetoggle.isOn = audioManager.IsMute;
    }
    public void SaveSettings () 
    {
        PlayerPrefs.SetFloat("bgmVolume", audioManager.BgmVolume);
        PlayerPrefs.SetInt("mute", audioManager.IsMute ? 1 : 0);
    }
}
