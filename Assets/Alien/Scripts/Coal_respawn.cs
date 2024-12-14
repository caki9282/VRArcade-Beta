using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coal_respawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float lifetime_max = 50.0f;
    float lifetime = 0;
    [SerializeField] public GameObject spawner;

    void Start()
    {
        lifetime = lifetime_max;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            lifetime = lifetime_max;
            gameObject.transform.position = spawner.transform.position;
        }
    }
}
