using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartPhone : MonoBehaviour
{
    public GameObject smartPhone;
 
    public void smartphoneon()
    {
        smartPhone.SetActive(true);
      
        Time.timeScale = 0;
    }
    public void smartphoneoff()
    {
        smartPhone.SetActive(false);

        Time.timeScale = 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
