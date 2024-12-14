using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] public GameObject spawner;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coal"))
        {
            //Destroy(other.gameObject); // Destroy coal
            Int_statics.Fuel++;
            Int_statics.Score++;
            Debug.Log(Int_statics.Fuel);

            //move object
            other.gameObject.transform.position = spawner.transform.position;
        }
    }
}
