using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    public bool colorred = false;
    public bool coloryellow = false;
    public bool colorgreen = false;

    public void selectedred()
    {
        if(colorred == true)
        {
            red.GetComponent<Renderer>().material.color = new Color(1,0,0);
            colorred = false;
        } 
        else if(colorred == false)
        {
            red.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            colorred = true;
        }
    }

    public void selectedyellow()
    {
        if (coloryellow == true)
        {
            yellow.GetComponent<Renderer>().material.color = new Color(1, 0.9f, 0);
            coloryellow = false;
        }
        else if (coloryellow == false)
        {
            yellow.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            coloryellow = true;
        }
    }

    public void selectedgreen()
    {
        if (colorgreen == true)
        {
            green.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
            colorgreen = false;
        }
        else if (colorgreen == false)
        {
            green.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            colorgreen = true;
        }
    }
}
