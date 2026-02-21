using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variable1 = "Hello ";
    // int counter = 3;

    // Start is called before the first frame update
    void Start()
    {
        string variable2 = "World";
        Debug.Log(variable1 + variable2);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(counter);
        // counter++;
        // transform.position += new Vector3(0.005f, 0, 0);
        if (Input.GetKeyDown(KeyCode.W))
        { transform.position += new Vector3(0, 1, 0); }
        else if (Input.GetKeyDown(KeyCode.S))
        { transform.position += new Vector3(0, -1, 0); }
        else if (Input.GetKeyDown(KeyCode.D))
        { transform.position += new Vector3(1, 0, 0); }
        else if (Input.GetKeyDown(KeyCode.A))
        { transform.position += new Vector3(-1, 0, 0); }
    }
}
