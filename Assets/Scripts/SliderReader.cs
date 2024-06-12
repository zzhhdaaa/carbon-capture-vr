using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class SliderReader : MonoBehaviour
{
    public TMPro.TextMeshPro text;
    VideoPlayer player;
    float sliderValue;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue = float.Parse(text.text);
        if (sliderValue < 0)
        {
            transform.localScale = new Vector3(1f, 1f, -1f);
        }
        else if (sliderValue >= 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        player.playbackSpeed = Mathf.Abs(sliderValue);
    }
}
