using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    //public GameObject lightbulb;
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) lightComponent.enabled = !lightComponent.enabled;

        /*if (Input.GetKeyDown(KeyCode.L))
        {
            if (lightComponent.enabled)
            {
                lightComponent.enabled = false;
            }
            else
            {
                lightComponent.enabled = true;
            }

        }*/
    }
}
