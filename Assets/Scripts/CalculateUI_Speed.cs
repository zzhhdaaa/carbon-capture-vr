using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateUI_Speed : MonoBehaviour
{
    Slider slider;
    float maxValue;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        maxValue = slider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = maxValue * DacSlider.instance.sliderValue;
    }
}
