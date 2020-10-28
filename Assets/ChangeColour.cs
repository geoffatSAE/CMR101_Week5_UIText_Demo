using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{

    public Text uiTextObject;
    public TextMesh textMeshObject;
    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRed() 
    {
        r.material.color = Color.red;

        uiTextObject.text = "colour is now red";
        textMeshObject.text = "colour is now red";
    }

    public void SetBlue()
    {
        r.material.color = Color.blue;

        uiTextObject.text = "colour is now blue";
        textMeshObject.text = "colour is now blue";
    }
}
