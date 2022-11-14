using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreatureStats :  MonoBehaviour 
{

    //needs
    public float hunger;
    public float sleep;
    public float mood;
    public float bladder;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



   int Hunger(int value)
    {
        
        return hunger;
    }

    int Sleep(int value)
    {
        return sleep;
    }

    int Mood(int value)
    {
        return mood += value;
    }

    int Bladder(int value)
    {

        return bladder += value;
    }
}
