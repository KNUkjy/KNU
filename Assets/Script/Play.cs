using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    private AudioSource theAudio;
    public GameObject player;
    [SerializeField] private AudioClip[] clip; 
  
    void Start()
    {
        theAudio = player.GetComponent<AudioSource>();
    }
    
    public void play0()
    {
        
        theAudio.clip = clip[0]; 
        theAudio.Play();
    }
    public void play1()
    {

        theAudio.clip = clip[1];
        theAudio.Play();
    }
    public void play2()
    {

        theAudio.clip = clip[2];
        theAudio.Play();
    }
}
