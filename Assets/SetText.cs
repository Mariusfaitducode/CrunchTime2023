using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
    public Text hauteur;
    public Text angle;
    
    public GameObject capsuleObject;

    public Text hauteurCaps;
    public Text largeurCaps;
    public Text poidsCaps;
    void Update()
    {
        Vector3 position = capsuleObject.transform.position;
        Quaternion rotation = capsuleObject.transform.rotation;
        
        
        
        hauteur.text = "Hauteur : " + position.y.ToString("F2") ; 
        angle.text = "Angle : " + (rotation.eulerAngles.z - 90).ToString("F2");
    }

    public void SetHauteur()
    {
        float a = float.Parse(hauteurCaps.text);
        a = a / 100;
        Vector3 scale = capsuleObject.transform.localScale;
        capsuleObject.transform.localScale = new Vector3((float)a, scale.y, scale.z);
    }
    
    public void SetLargeur()
    {
        //double a = Convert.ToDouble(largeurCaps.text);
        float a = float.Parse(largeurCaps.text);
        
        
        a = a / 31.25f;
        Vector3 scale = capsuleObject.transform.localScale;
        capsuleObject.transform.localScale = new Vector3(scale.x, (float)a, (float)a);
    }

    public void SetPoids()
    {
        float a = float.Parse(poidsCaps.text);
        a = a / 100;
        //Vector3 scale = capsuleObject.transform.localScale;
        //capsuleObject.transform.localScale = new Vector3((float)a, scale.y, scale.z);

        capsuleObject.GetComponent<Rigidbody>().mass = a;
    }
}
