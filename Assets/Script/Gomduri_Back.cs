using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gomduri_Back : MonoBehaviour
{
    public GameObject diallog;
    public GameObject gomBdiallog;
    public void OnMouseDown()
    {
        diallog.SetActive(true);
        gomBdiallog.SetActive(true);
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
