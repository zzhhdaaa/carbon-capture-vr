using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTurbine : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.forward, -DacSlider.instance.sliderValue*speed*Time.deltaTime);
    }
}
