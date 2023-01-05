using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject diallog;
    public GameObject diallog1;
    public GameObject diallog2;
    public GameObject diallog3;
    public GameObject diallog4;
    public GameObject diallog5;
    public GameObject diallog6;
    public GameObject diallog7;
    public GameObject diallog8;
    public GameObject diallog9;
    public GameObject diallog10;
    public GameObject diallog11;
    public GameObject diallog12;
    public GameObject diallog13;
    public GameObject diallog14;
    public GameObject diallog15;
    


    public void diallogExit()
    {
        diallog.SetActive(false);
        diallog1.SetActive(false);
        diallog2.SetActive(false);
        diallog3.SetActive(false);
        diallog4.SetActive(false);
        diallog5.SetActive(false);
        diallog6.SetActive(false);
        diallog7.SetActive(false);
        diallog8.SetActive(false);
        diallog9.SetActive(false);
        diallog10.SetActive(false);
        diallog11.SetActive(false);
        diallog12.SetActive(false);
        diallog13.SetActive(false);
        diallog14.SetActive(false);
        diallog15.SetActive(false);
       
        Time.timeScale = 1;
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
