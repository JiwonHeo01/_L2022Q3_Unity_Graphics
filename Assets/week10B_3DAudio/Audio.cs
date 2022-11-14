using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audio.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audio.Stop();
        }
    }
}
