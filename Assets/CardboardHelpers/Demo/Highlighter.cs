using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public Color hoverColor;
    public Color selectColor;

    private Color defaultColor;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        defaultColor = renderer.material.color;
    }

    public void Hovering(bool enable)
    {
        renderer.material.color = (enable ? hoverColor : defaultColor);
    }

    public void Selecting(bool enable)
    {
        renderer.material.color = (enable ? selectColor : defaultColor);
    }

}
