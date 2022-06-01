using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool windowCollision;

    [SerializeField]
    float upspeed, downspeed, sidespeed;

    [SerializeField]
    KeyCode up, down, left, right, interact;

    public void OnTriggerStay2D(Collider2D collision)
    {
        windowCollision = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        windowCollision = false;
    }

    private void Start()
    {

    }
    void Update()
    {
        #region Movement
        if (Input.GetKey(up)) //n�r knappen W �r nere
        {
            transform.position += new Vector3(0, upspeed, 0) * Time.deltaTime; //�ndras positionen till riktning upp�t i detta fall
        }

        if (Input.GetKey(down))
        {
            transform.position -= new Vector3(0, downspeed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(sidespeed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(right))
        {
            transform.position += new Vector3(sidespeed, 0, 0) * Time.deltaTime;
        }
        #endregion

        if (windowCollision)
        {
            if (Input.GetKeyDown(interact))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
