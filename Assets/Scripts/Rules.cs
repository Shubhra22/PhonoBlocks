using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rules : MonoBehaviour
{
    [SerializeField]
    private Color[] cbc;
    
    public Text word;

    private string ruleStr;

    private string resultStr;
    void Update()
    {
        foreach(KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if(Input.GetKeyUp(vKey))
            {
                resultStr += vKey.ToString();
            }
        }

        //word.text = resultStr;
        CBC(resultStr);
    }

    void CBC(String s)
    {
        word.text = ColorText.TextToColor(s, cbc);
    }

    void Blend(string[] blends)
    {
        
    } 
}
