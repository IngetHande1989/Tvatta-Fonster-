using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmutsCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "dirtywindow")
        {
            Destroy(collision.gameObject);
        }
    }
}
