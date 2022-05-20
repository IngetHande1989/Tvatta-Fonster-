using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject mainmenu;
    public GameObject optionsscreen;
    [SerializeField]
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void playgame()
    {
        print("tja");
        vp.Play();
        System.Threading.Thread.Sleep(3000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loada nästa scen i builden


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
