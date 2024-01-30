using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int m=1; m<13; m++)
        {
            if (m==2)
            {
                //Debug.Log("its my bday!");

                for (int d=1; d<30; d++)
                {
                    if (d==29)
                    {
                        Debug.Log("its my bday!"); 
                    }
                    else 
                    {
                        Debug.Log(d);
                    }
                }
            }
            else
            {
                Debug.Log(m);
            }
        }

        //while ()

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
