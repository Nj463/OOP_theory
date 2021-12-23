using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : Shapes
{    
    public Text textoflines;
    private bool isRolling=false;
    private int angle = 5;
    
    public void OnMouseDown()
    {
        textoflines.text = "Sphere  ";
        isRolling = true;
        ShowUI();
        Roll();
    }
    public void OnMouseExit()
    {
        isRolling = false;
        HideUI();
    }

    private void Roll()
    {
        for (int i = 0; i < 5; i++)
        {
            transform.Rotate(0, angle * Time.deltaTime, angle * Time.deltaTime);
        }
       
        
    }

    

}
