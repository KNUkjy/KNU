using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public GameObject questpostbox;
    public GameObject quest;
    
    [SerializeField]
    public GameObject[] questList;
 
    public void questBoxOpen()
    {
        questpostbox.SetActive(true);
        Time.timeScale = 0;
    }
    public void questBoxClose()
    {
        questpostbox.SetActive(false);
        Time.timeScale = 1;
    }
    public void questlist()
    {
        for (int i = 1; i <= questList.Length; i++)
        {
            questList[i].SetActive(false);
        }

    }
    void Start()
    {
        questlist();
        
    }

 
    void Update()
    {
        
    }
}
