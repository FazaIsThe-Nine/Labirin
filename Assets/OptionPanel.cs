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
}
