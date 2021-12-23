using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shapes
{
    private Rigidbody rb;
    public Text textoflines;
    private bool hasJumped=false;
    public void OnMouseDown()
    {
        rb = GetComponent<Rigidbody>();
        textoflines.text = "Cube  ";
        ShowUI();
        Jump();
    }
    public void OnMouseExit()
    {
        HideUI();
        hasJumped = false;
    }
    private void Jump()
    {
        if (!hasJumped)
        {
            rb.AddForce(0, 210, 0);
            hasJumped = true;
        }
        
        

        
        
    }
}
