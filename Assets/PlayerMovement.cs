using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float upspeed = 3;
    [SerializeField]
    float downspeed = 2;
    [SerializeField]
    float sidespeed = 2;
    [SerializeField]

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //n�r knappen W �r nere
        {
            transform.position += new Vector3(0, upspeed, 0) * Time.deltaTime; //�ndras positionen till riktning upp�t i detta fall
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, downspeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(sidespeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(sidespeed, 0, 0) * Time.deltaTime;
        }
    }
}
