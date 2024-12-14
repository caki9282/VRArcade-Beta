using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_ex1 : MonoBehaviour
{
    //statics point to the same reference in every instance of the calss
    public static int count_me = 0;

    // Start is called before the first frame update
    void Start()
    {
        count_me++;
        Debug.Log(count_me);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
