using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DacSliderController : MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public float speedMultiplier;
    SpinTurbine spinTurbine;
    float sliderValue;


    // Start is called before the first frame update
    void Start()
    {
        spinTurbine = GetComponent<SpinTurbine>();
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue = float.Parse(text.text);
        spinTurbine.speed = sliderValue * speedMultiplier;
    }
}
