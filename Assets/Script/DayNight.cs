using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Material DayMaterial;
    public Material NightMaterial;
    public GameObject daylight;
    public GameObject moonlight;
    public GameObject daybutton;
    public GameObject nightbutton;
    public GameObject Streetlamp;
    public GameObject Campus;

    public void Daychange()
    {
        RenderSettings.skybox = DayMaterial;
        Campus.AddComponent<Skybox>().material = DayMaterial;
        daybutton.SetActive(true);
        Streetlamp.SetActive(false);
        nightbutton.SetActive(false);
        daylight.SetActive(true);
        moonlight.SetActive(false);
    }
    public void nightchange()
    {
        RenderSettings.skybox = NightMaterial;
        Campus.AddComponent<Skybox>().material = NightMaterial;
        daybutton.SetActive(false);
        Streetlamp.SetActive(true);
        nightbutton.SetActive(true);
        daylight.SetActive(false);
        moonlight.SetActive(true);
    }
    void Start()
    {
        
    }
    
    
    void Update()
    {
        
    }
}
