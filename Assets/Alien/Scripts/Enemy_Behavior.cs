using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private float speed = 10f;
    [SerializeField] private GameObject Bullet;
    private GameObject playerTarget;
    private float targer_timer = 0.0f;
    [SerializeField] private float shoot_timer_max = 5.0f;
    private float shoot_timer = 5.0f;

    [SerializeField] private Vector3 target_offset = Vector3.zero;
    public Vector3 start = Vector3.zero;
    [SerializeField] private float travel_time = 5.0f;
    public float travel_timer = 0.0f;

    void Start()
    {
        start = transform.position;
    }

    // When the player enters the trigger, assign it as a target
    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Player"))
        {
            playerTarget = other.gameObject;
            targer_timer = 4.0f;        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        travel_timer += Time.deltaTime;
        targer_timer -= Time.deltaTime;
        shoot_timer  -= Time.deltaTime;
        // Only move forward if there is a player target
        if (playerTarget != null && targer_timer >= 0.1) 
        {
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if(shoot_timer <= 0)
        {
            shoot_timer = shoot_timer_max;
            shoot();
        }

        move();
    }

    void shoot()
    {
        Vector3 offset = new Vector3(0,-1.5f,0);
        GameObject new_bullet = Instantiate(Bullet, transform.position+offset, transform.rotation);
        float scale = 2.0f;
        new_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 150.0f * scale);
    
        //play audio
        //GetComponent<AudioSource>.AudioSource.Play();
    }

    void move()
    {
        float t = 0.0f;
        t = travel_timer / travel_time;
        //Debug.Log("Moving enemy");
        if((float) Math.Floor(t) % 2 == 1)
        {
            t -= (float) Math.Floor(t);
            t = 1.0f - t;
            //Debug.Log("Moving enemy, Backwards");
        }
        else
        {
            t -= (float) Math.Floor(t);
        }
        transform.position = Vector3.Lerp(start, start + target_offset, t);

    }
}
