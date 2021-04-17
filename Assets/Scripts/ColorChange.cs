using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public string name;
    public Color myColor;
    Renderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
           myRenderer.material.SetColor("_Color", Color.red);
        else if (Input.GetKey("2"))
           myRenderer.material.SetColor("_Color", Color.blue);
        else if (Input.GetKey("3"))
           myRenderer.material.SetColor("_Color", Color.green);
    }
}
