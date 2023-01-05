using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    public GameObject startimage;
    public GameObject helloText;
    public GameObject infoText;
    public GameObject exampleText;
    public GameObject exampleimage;
    public GameObject exampleText1;
    public GameObject exampleimage1;
    public GameObject exampleText2;
    public GameObject exampleimage2;
    public GameObject exampleText3;
    public GameObject exampleimage3;
    public GameObject CampusTransformText;

    public void startImage()
    {
        startimage.SetActive(false);
        helloText.SetActive(true);
    }
    public void HelloText()
    {
        helloText.SetActive(false);
        infoText.SetActive(true);
    }
    public void Yes()
    {
        infoText.SetActive(false);
        exampleText.SetActive(true);
        exampleimage.SetActive(true);
    }
    public void No()
    {
        infoText.SetActive(false);
        CampusTransformText.SetActive(true);
    }
    public void example()
    {
        exampleText.SetActive(false);
        exampleimage.SetActive(false);
        exampleText1.SetActive(true);
        exampleimage1.SetActive(true);
    }
    public void example1()
    {
        exampleText1.SetActive(false);
        exampleimage1.SetActive(false);
        exampleText2.SetActive(true);
        exampleimage2.SetActive(true);
    }
    public void example2()
    {
        exampleText2.SetActive(false);
        exampleimage2.SetActive(false);
        exampleText3.SetActive(true);
        exampleimage3.SetActive(true);
    }
    public void example3()
    {
        exampleText3.SetActive(false);
        exampleimage3.SetActive(false);
        CampusTransformText.SetActive(true);
    }
    public void StartButton()
    {
        SceneManager.LoadScene("Campus");
    }
}
