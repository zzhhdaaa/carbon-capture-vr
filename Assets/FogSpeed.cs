using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogSpeed : MonoBehaviour
{
    ParticleSystem m_ParticleSystem;
    float initialSpeed;

    // Start is called before the first frame update
    void Start()
    {
        m_ParticleSystem = GetComponent<ParticleSystem>();
        initialSpeed = m_ParticleSystem.startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        m_ParticleSystem.startSpeed = initialSpeed * DacSlider.instance.sliderValue;
    }
}
