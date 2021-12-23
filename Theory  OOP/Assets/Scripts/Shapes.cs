using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shapes : MonoBehaviour
{
    public GameObject text;
         
    public virtual void ShowUI()
    {
        text.SetActive(true);
        
    }
    public virtual void HideUI()
    {
        text.SetActive(false);
    }
}
