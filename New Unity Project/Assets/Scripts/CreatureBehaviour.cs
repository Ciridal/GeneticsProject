using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureBehaviour : MonoBehaviour
{
    CreatureStats stats;

    float decay = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        stats = FindObjectOfType<CreatureStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position.x *= Time.deltaTime * stats.speed;
    }

    private void FixedUpdate()
    {
        
    }

    void Eat()
    {
        stats.hunger+= 10; //not final
    }

    void Sleep()
    {
        stats.sleep++;
    }

    void Play()
    {
        stats.mood++;
    }

    void Poop()
    {
        stats.hunger--;
        //spawn poops
    }

    void Roam()
    {

        // health -= coef * Time.deltaTime;
        stats.hunger -= decay * Time.deltaTime;
    }

    
}
