using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGet : MonoBehaviour
{
    public GameObject meggage;
    public GameObject meggage1;
    public GameObject meggage2;
    public GameObject meggage3;
    public GameObject[] QuestList;
    public GameObject QuestGetTxt;
    public Quest Quest;
    IEnumerator questGetText()
    {
        QuestGetTxt.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        QuestGetTxt.SetActive(false);
    }
    public void MessageOpen()
    {
        meggage.SetActive(true);
    }
    public void MessageOpen1()
    {
        meggage1.SetActive(true);
    }
    public void MessageOpen2()
    {
        meggage2.SetActive(true);
    }
    public void MessageOpen3()
    {
        meggage3.SetActive(true);
    }
    public void MessageActive()
    {
        QuestList[0].SetActive(true);
        StartCoroutine(questGetText());
    }
    public void MessageActive1()
    {
        QuestList[1].SetActive(true);
        StartCoroutine(questGetText());
    }
    public void MessageActive2()
    {
        QuestList[2].SetActive(true);
        StartCoroutine(questGetText());
    }
    public void MessageActive3()
    {
        QuestList[3].SetActive(true);
        StartCoroutine(questGetText());
    }
    void Start()
    {
        Quest = GameObject.Find("Player").GetComponent<Quest>();
        QuestList = Quest.questList;
        StartCoroutine(questGetText());
    }


    void Update()
    {
        
    }
}
