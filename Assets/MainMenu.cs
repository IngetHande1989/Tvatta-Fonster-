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
        Debug.Log("Player left the game.");
        Application.Quit();
    }
    public void playgame()
    {
        print("tja");
        
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loada nästa scen i builden


    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

}
