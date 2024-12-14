using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class KILL_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int HP = 1;
    //[SerializeField] String Bullet_tag;

    void Update()
    {
        if(HP <= 0)
        {
            Destroy(gameObject.transform.parent.gameObject);
            Int_statics.Score += 5;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        
        Debug.Log("Enemy Hit!");
        
        if(other.CompareTag("Bullet") || other.CompareTag("Coal"))
        {
            Debug.Log("it was a bullet");
            //Destroy(other);
            //Destroy(gameObject);
            HP -= 1;
        }//*/

        //Destroy(gameObject);
    }
}
