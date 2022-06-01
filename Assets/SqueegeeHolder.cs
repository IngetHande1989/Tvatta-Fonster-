using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqueegeeHolder : MonoBehaviour
{
    bool squeegeeActive = false;

    [SerializeField]
    Transform squeegee;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!squeegeeActive)
            {
                squeegeeActive = true;
                squeegee.gameObject.SetActive(true);
            }

            else
            {
                squeegeeActive = false;
                squeegee.gameObject.SetActive(false);
            }
        }
    }
}
