using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    float stopWatchTime;
    bool stopWatchStarted;
    float stopWatchTimeSeconds;
    float stopWatchTimeMinutes;
    float stopWatchTimeHours;
    private Rigidbody selfRigidbody;
    public float jumpVelocity = 2;
    private Collision collision1;
    private bool inCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        stopWatchTime = 0.0f;
        stopWatchStarted = false;
        selfRigidbody = GetComponent<Rigidbody>();
    }

    bool IsGrounded()
    {
        Collider col = gameObject.GetComponent<Collider>();
        return Physics.Raycast(transform.position, -Vector3.up, col.bounds.extents.y + 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            selfRigidbody.AddForce(collision1.GetContact(0).normal * jumpVelocity, ForceMode.VelocityChange);
        }
    }

    private void FixedUpdate()
    {
        if (stopWatchStarted)
        {
            updateStopWatchTime();
        }
    }

    void updateStopWatchTime()
    {
        stopWatchTime += Time.deltaTime;

        stopWatchTimeSeconds = (int)(stopWatchTime % 60);
        stopWatchTimeMinutes = (int)((stopWatchTime / 60) % 60);
        stopWatchTimeHours = (int)(stopWatchTime / 3600);
    }

    private void OnCollisionStay(Collision collision)
    {
        collision1 = collision;
    }

    private void OnCollisionExit(Collision other)
    {
        stopWatchTime = 0.0f;
        stopWatchStarted = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.tag == "start")
        {
            stopWatchStarted = false;
        }

        if (other.collider.gameObject.tag == "end")
        {
            stopWatchStarted = false;
            Debug.Log("Done in " + stopWatchTimeHours.ToString("00") + ":" + stopWatchTimeMinutes.ToString("00") + ":" + stopWatchTimeSeconds.ToString("00"));
        }
    }
}
