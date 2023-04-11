using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public Color hoverColor;
    public Color selectColor;

    private Color defaultColor;
    private Renderer rendererRef;

    private void Start()
    {
        rendererRef = GetComponent<Renderer>();
        defaultColor = rendererRef.material.color;
    }

    public void Hovering(bool enable)
    {
        rendererRef.material.color = (enable ? hoverColor : defaultColor);
    }

    public void Selecting(bool enable)
    {
        rendererRef.material.color = (enable ? selectColor : defaultColor);
    }

}
