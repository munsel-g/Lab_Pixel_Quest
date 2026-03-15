using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GeoController : MonoBehaviour
{
   // string variable1 = "Hello ";
    // int counter = 3;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public int speed = 5;
    public string nextLevel = "Scene-2";

    // Start is called before the first frame update
    void Start()
    {
      //  string variable2 = "World";
      //  Debug.Log(variable1 + variable2);
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(counter);
        // counter++;
        // transform.position += new Vector3(0.005f, 0, 0);

        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (Input.GetKeyDown(KeyCode.W))
        { transform.position += new Vector3(0, 1, 0); }
        else if (Input.GetKeyDown(KeyCode.S))
        { transform.position += new Vector3(0, -1, 0); }
        else if (Input.GetKeyDown(KeyCode.D))
        { transform.position += new Vector3(1, 0, 0); }
        else if (Input.GetKeyDown(KeyCode.A))
        { transform.position += new Vector3(-1, 0, 0); }

        if (Input.GetKey(KeyCode.UpArrow))
        { transform.position += new Vector3(0, .01f, 0); }
        else if (Input.GetKey(KeyCode.DownArrow))
        { transform.position += new Vector3(0, -.01f, 0); }
        else if (Input.GetKey(KeyCode.RightArrow))
        { transform.position += new Vector3(.01f, 0, 0); }
        else if (Input.GetKey(KeyCode.LeftArrow))
        { transform.position += new Vector3(-.01f, 0, 0); }

        if (Input.GetKey(KeyCode.R))
        { transform.position = new Vector3(0, 0, 0); }
        *///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (xInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        { sr.color = Color.magenta; }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            { sr.color = Color.yellow; }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            { sr.color = Color.cyan; }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        { case "Death":
                { 
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Player Has Died");
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    Debug.Log("Player Has Advanced to Next Stage");
                    break;
                }
        }
    }
}
