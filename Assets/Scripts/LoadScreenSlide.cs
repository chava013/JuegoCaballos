using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreenSlide : MonoBehaviour
{
    private Slider slider;
    public float fillSpeed;
    private float targetProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>(); 
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }

    void Start()
    {
        IncrementProgress(1);
    }

    void Update()
    {
       if(slider.value < targetProgress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
        if (slider.value == 1)
            SceneManager.LoadScene("MainMenu");
    }
}
