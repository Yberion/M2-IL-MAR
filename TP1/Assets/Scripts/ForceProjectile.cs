using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceProjectile : MonoBehaviour
{
    private Rigidbody rB;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rB.AddForce(10.0f * Vector3.right);
    }
}
