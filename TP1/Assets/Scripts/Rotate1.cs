using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour
{
    public float angle = 5.0f;
    public float speed = 5.0f;
    public KeyCode keyRotate = KeyCode.E;
    private bool rotateToggle = false;
    private Color previousColor = Color.red;
    private Renderer compRenderer;

    // Start is called before the first frame update
    void Start()
    {
        compRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyRotate))
        {
            rotateToggle = !rotateToggle;
        }

        if (!rotateToggle)
        {
            if (Input.GetKey(KeyCode.R))
            {
                transform.Rotate(0, angle * Time.deltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(0, -angle * Time.deltaTime, 0);
            }
        }
        else
        {
            transform.Rotate(0, angle * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }

    void OnMouseEnter()
    {
        previousColor = compRenderer.materials[0].color;
        compRenderer.materials[0].color = Color.blue;
    }

    void OnMouseExit()
    {
        compRenderer.materials[0].color = previousColor;
    }
}
