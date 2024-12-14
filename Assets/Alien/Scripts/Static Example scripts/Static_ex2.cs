using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_ex2 : MonoBehaviour
{
    //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Static_ex1.count_me + 10);
    }
}
