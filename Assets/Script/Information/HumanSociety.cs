using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSociety : MonoBehaviour
{
    public GameObject diallog;
    public GameObject hsdiallog;
    public GameObject ItemGetTxt;
    public GameObject[] ItemList;
    public Inventory inven;
    IEnumerator ItemGet()
    {
        ItemGetTxt.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        ItemGetTxt.SetActive(false);
    }
    public void OnMouseDown()
    {
        diallog.SetActive(true);
        hsdiallog.SetActive(true);
        Time.timeScale = 0;
        ItemList[6].SetActive(true);
        StartCoroutine(ItemGet());
    }
    void Start()
    {
        inven = GameObject.Find("Player").GetComponent<Inventory>();
        ItemList = inven.itemList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
