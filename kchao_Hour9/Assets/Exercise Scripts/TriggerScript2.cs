using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has ENTERED the trigger: " + name);
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has EXITED the trigger: " + name);
    }

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " has STAYED in the trigger: " + name);
    }
}
