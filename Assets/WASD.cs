using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            // w ->앞
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
            float v = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(0f, 0f, MoveSpeed * v * Time.deltaTime));
                //transform.position += new Vector3(0.0f, 0.0f, MoveSpeed*Time.deltaTime);
            }
            // s->뒤
  
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) 
            {
                float h = Input.GetAxis("Horizontal");
                //transform.position -= new Vector3(MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
                GetComponent<Transform>().Rotate(new Vector3(0, h * 120f * Time.deltaTime, 0));
            }


    }
}
