using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DacSlider : MonoBehaviour
{
    public static DacSlider instance;

    public TMPro.TextMeshPro text;
    public float sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue = float.Parse(text.text);
    }
}
