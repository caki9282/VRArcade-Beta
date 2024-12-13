using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem; 

public class TMP_Fuel_Disp : MonoBehaviour
{
    int num = 0;
    void Start()
    {
        write_text();
    }
    void Update()
    {
        if(num != Int_statics.Fuel)
        {
            num = Int_statics.Fuel;
            write_text();
        }
    }

    void write_text()
    {
        string msg_string = "Fuel: " + num.ToString();
        GetComponent<TMP_Text>().SetText(msg_string);
    }
}
