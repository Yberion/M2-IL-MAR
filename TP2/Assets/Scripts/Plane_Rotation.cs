using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Rotation : MonoBehaviour
{

    public float speed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }
}
