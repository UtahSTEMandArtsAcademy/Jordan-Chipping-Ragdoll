//must speed up the flames

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameEruption : MonoBehaviour
{
    public float timeBeforeFire;
    private float eruptionTime;
    public ParticleSystem warningSmoke;
    public float speed = 10;

    void Start()
    {
        eruptionTime = timeBeforeFire;
    }

    // Update is called once per frame
    void Update()
    {
        eruptionTime -= Time.deltaTime;
        if(eruptionTime >= -2)
        {
            warningSmoke.Play();
        }
        else if(eruptionTime >= -3)
        {
            Vector3 flameHeight = transform.position;
            if(flameHeight.y <= 5.45f){
                flameHeight.y += Time.deltaTime * speed;
            }
            transform.position = flameHeight;
        }
        else if(eruptionTime >= -4){
            Vector3 flameHeight = transform.position;
            if(flameHeight.y >= -2.85f){
                flameHeight.y -= Time.deltaTime * speed;
            }
            transform.position = flameHeight;
        }
        else
        {
            eruptionTime = timeBeforeFire;
            
        }
    }
}
