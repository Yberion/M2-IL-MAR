using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public GameObject cible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (transform.position - cible.transform.position).normalized * 10 + cible.transform.position;

        transform.LookAt(cible.transform);

        float mouseX = Input.GetAxis("Mouse X");
        
        if (mouseX > 0)
        {
            transform.RotateAround(cible.transform.position, Vector3.up, 100.0f * Time.deltaTime);
        }
        else if (mouseX < 0)
        {
            transform.RotateAround(cible.transform.position, Vector3.up, -100.0f * Time.deltaTime);
        }

        float mouseY = Input.GetAxis("Mouse Y");

        if (mouseY > 0)
        {
            transform.RotateAround(cible.transform.position, Vector3.right, -100.0f * Time.deltaTime);
        }
        else if (mouseY < 0)
        {
            transform.RotateAround(cible.transform.position, Vector3.right, 100.0f * Time.deltaTime);
        }
    }
}
