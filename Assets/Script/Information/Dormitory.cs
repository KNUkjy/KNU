using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormitory : MonoBehaviour
{
    public GameObject diallog;
    public GameObject dormitorydiallog;
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
        dormitorydiallog.SetActive(true);
        Time.timeScale = 0;
        ItemList[5].SetActive(true);
        StartCoroutine(ItemGet());
    }
    // Start is called before the first frame update
    void Start()
    {
        inven = GameObject.Find("Player").GetComponent<Inventory>();
        ItemList = inven.itemList;
    }

    // Update is called once per frame
    void Update()
    {
        if (diallog.activeSelf == true)
        {
            Time.timeScale = 0;
        }
    }
}
