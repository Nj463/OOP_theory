using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cyllinder : Shapes
{
    public Text textoflines;
    private bool resized = false;

    public void OnMouseDown()
    {
        textoflines.text = "Cyllinder  ";
        ShowUI();
        Changesize();
    }
    public void OnMouseExit()
    {
        HideUI();
        Changesize(resized);
    }

    private void Changesize()
    {
        if(!resized)
        {
            transform.localScale *= 2;
            resized = true;
        }
        
    }
    private void Changesize(bool isdone)
    {
        isdone = resized;
        if(isdone)
        {
            transform.localScale /= 2;
            resized = false;
        }
        
    }
}
