using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public GameObject skieur;
    public GameObject positionOptimal;
    private Rigidbody cameraRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        this.cameraRigidBody = this.gameObject.GetComponent<Rigidbody>();
        this.gameObject.transform.position = positionOptimal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.gameObject.transform.LookAt(skieur.transform);
        Vector3 vectCameraPosToPlayerPos = positionOptimal.transform.position - this.gameObject.transform.position;
        cameraRigidBody.AddForce(vectCameraPosToPlayerPos);
        cameraRigidBody.AddForce(-cameraRigidBody.velocity * 0.3f);
    }
}
