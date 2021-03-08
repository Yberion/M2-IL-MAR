using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkieurControles : MonoBehaviour
{
    private Collider skiCollider;
    private Rigidbody skiRigidbody;
    private float dynamicFrictionOldValue;

    // Start is called before the first frame update
    void Start()
    {
        skiCollider = gameObject.GetComponent<Collider>();
        skiRigidbody = gameObject.GetComponent<Rigidbody>();
        dynamicFrictionOldValue = skiCollider.material.dynamicFriction;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            skiCollider.material.dynamicFriction = 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            skiCollider.material.dynamicFriction = dynamicFrictionOldValue;
        }
    }
}
