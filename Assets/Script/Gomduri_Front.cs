using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gomduri_Front : MonoBehaviour
{
    public GameObject diallog;
    public GameObject gomFdiallog;
    public void OnMouseDown()
    {
        diallog.SetActive(true);
        gomFdiallog.SetActive(true);
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
