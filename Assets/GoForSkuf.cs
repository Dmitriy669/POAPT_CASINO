using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForSkuf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) & transform.position.y <= 8.10f){
            transform.position += new Vector3(0, 0.03f, 0);
        }
        if(Input.GetKey(KeyCode.A) & transform.position.x >= -18.10f){
            transform.position += new Vector3(-0.03f, 0, 0);
        }
        if(Input.GetKey(KeyCode.S) & transform.position.y >= -8.70f){
            transform.position += new Vector3(0, -0.03f, 0);
        }
        if(Input.GetKey(KeyCode.D) & transform.position.x <= 18.5f){
            transform.position += new Vector3(0.03f, 0, 0);
        }
    }
}
