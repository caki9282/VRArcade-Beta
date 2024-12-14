using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem; 
public class TMP_Fuel : MonoBehaviour
{
    int num = 0;
    int num_score = 0;
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

        if(num_score != Int_statics.Score)
        {
            num_score = Int_statics.Score;
            write_text();
        }
    }

    void write_text()
    {
        string msg_string = "Fuel: " + num.ToString() + "\nScore: " + num_score.ToString();
        GetComponent<TMP_Text>().SetText(msg_string);
    }
}
