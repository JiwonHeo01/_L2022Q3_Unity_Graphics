using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveShader1 : MonoBehaviour
{
    int brightness = 1;
    Renderer MyRenderer;

    void Start()
    {
        MyRenderer = gameObject.GetComponent<Renderer>();
        MyRenderer.material.SetInt("_Brightness", brightness);
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        brightness = -1 * brightness;
        MyRenderer.material.SetInt("_Brightness", brightness);
    }
}
