using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int counter = 0;
    void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name + " has COLLIDED with: " + name);
        counter++;
        print(counter);
    }
}
