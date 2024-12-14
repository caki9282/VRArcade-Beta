using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Crate"))
        {
            //Destroy(other.gameObject); // Destroy coal
            
            Int_statics.Score++;

            //move object
        }
    }
}
