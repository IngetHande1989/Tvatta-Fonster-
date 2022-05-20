using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float upspeed, downspeed, sidespeed;

    [SerializeField]
    Transform UI;

    [SerializeField]
    KeyCode up, down, left, right, interact;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "dirtywindow")
        {
            UI.gameObject.SetActive(true);

            if (Input.GetKeyDown(interact))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.gameObject.SetActive(false);
    }

    private void Start()
    {
        UI.gameObject.SetActive(false);
    }
    void Update()

        {
        #region Movement
        if (Input.GetKey(up)) //när knappen W är nere
        {
            transform.position += new Vector3(0, upspeed, 0) * Time.deltaTime; //ändras positionen till riktning uppåt i detta fall
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

    }
}
