using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkupStairs : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 heightOffset;
    public float Stairheight, climbspeed, dist, Div;
    public LayerMask Stairs;

    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float y = Input.GetAxisRaw("Horizontal");

        RaycastHit hit;

        if(Physics.Raycast(player.position + heightOffset , player.forward ,out hit , dist, Stairs))
        {
            Vector3 ClimbPos = new Vector3(player.position.x , player.position.y + Stairheight , player.position.z);
            if(y == 1){
            player.position = Vector3.Lerp(player.position , ClimbPos + player.forward / Div , climbspeed);
            }
        }
    }
}
