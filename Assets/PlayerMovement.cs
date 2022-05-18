using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float upspeed = 3;
    [SerializeField]
    float downspeed = 2;
    [SerializeField]
    float sidespeed = 2;
    [SerializeField]
    Transform UI;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dirtywindow")
        {
            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene("Cleangame");
            }
            UI.gameObject.SetActive(true);

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

    
        if (Input.GetKey(KeyCode.W)) //när knappen W är nere
        {
            transform.position += new Vector3(0, upspeed, 0) * Time.deltaTime; //ändras positionen till riktning uppåt i detta fall
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
