using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision objOther)
    {
        if (objOther.collider.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
        }
        
        if (objOther.collider.gameObject.tag == "mon_cube")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
