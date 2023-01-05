using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
    
   
{
    public GameObject diallog;
    public GameObject busdiallog;
   public void OnMouseDown()
    {
        diallog.SetActive(true);
        busdiallog.SetActive(true);
        Time.timeScale = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
