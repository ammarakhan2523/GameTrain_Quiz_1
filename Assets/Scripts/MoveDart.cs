using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDart : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
            // move the the dart in y axis 
            transform.Rotate(0, 0.5f, 0);
        
    }
}
