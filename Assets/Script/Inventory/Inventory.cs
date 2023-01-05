using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inven;
    public GameObject itemslots;
    bool activeInven = false;
   
    [SerializeField]
    public GameObject[] itemList;
    
    public void itemlist()
    {
        for(int i = 0; i <= itemList.Length; i++)
        {
            itemList[i].SetActive(false);
        }
       
    }
    void Start()
    { 
     itemlist();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInven = !activeInven;
            inven.SetActive(activeInven);
        }
    }
}
