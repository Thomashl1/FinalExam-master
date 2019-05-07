using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{

    public InputField PlayerInput;
    string Name;

    public void Start()
    {
        Name = PlayerPrefs.GetString("PlayerName");
        PlayerInput.text = Name;
    }

    public void SaveName()
    {
        Name = PlayerInput.text;
        PlayerPrefs.SetString("PlayerName", Name);
    }

}
