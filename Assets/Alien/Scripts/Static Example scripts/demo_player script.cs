using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class demo_playerscript : MonoBehaviour
{
    public int hp = 10;
    private float hit_timer = 1f;


    // Update is called once per frame
    void Update()
    {
        hit_timer -= Time.deltaTime;

        if(hit_timer >= 0)
        {
            hit_timer = 1.0f;
            hp--;

            //this is how we can call an event from anywhere
            App_event_manager.Player.On_health_changed.Invoke(this, hp);
        }
    }
}
