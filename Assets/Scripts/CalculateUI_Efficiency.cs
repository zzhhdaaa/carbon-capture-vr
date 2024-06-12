using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateUI_Efficiency : MonoBehaviour
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
        if (DacSlider.instance.sliderValue <= 0)
        {
            slider.value = 0f;
        }
        else
        {
            slider.value = maxValue * Mathf.Sin(DacSlider.instance.sliderValue * 2f * Mathf.PI / 3f);
        }
    }
}
