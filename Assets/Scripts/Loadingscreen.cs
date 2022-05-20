using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadingscreen : MonoBehaviour
{
    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 9.0f;
    private float startTime;
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time; //starttiden baseras på den riktiga tiden
        StartCoroutine(SelfDestruct()); //starta couroutine selfdestruct
    }
    IEnumerator SelfDestruct() //en timer enkel timer som bestämmer hur lång scenen ska vara
    {
        float b = (Time.time - startTime) / duration; //timer
        yield return new WaitForSeconds(9f); //pausa i 9 sekunder
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loada nästa scen i builden
    }

    void Update()
    {
        float t = (Time.time - startTime) / duration; //timer
        sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(minimum, maximum, t)); //fadea in spriten
    }
}
