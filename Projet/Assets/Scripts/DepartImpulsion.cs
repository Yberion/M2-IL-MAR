using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepartImpulsion : MonoBehaviour
{
    private Rigidbody skieurRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        skieurRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            skieurRigidbody.AddForce(gameObject.transform.forward * 40, ForceMode.Impulse);
        }
    }
}
