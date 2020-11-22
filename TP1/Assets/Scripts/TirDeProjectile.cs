using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirDeProjectile : MonoBehaviour
{
    public GameObject projectile;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
