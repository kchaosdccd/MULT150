using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    public int runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        print("start runs before an obj updates");
    }

    // Update is called once per frame
    void Update()
    {
        print("this is called once a frame");
    }
}
