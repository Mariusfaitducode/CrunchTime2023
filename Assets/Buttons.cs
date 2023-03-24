using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Buttons : MonoBehaviour
{
    public CapsuleMouvement capsule;
    public Button avancerButton;

    public Canvas canva1;
    public Canvas canvaPara;
    
    public void Appliquer()
    {
        capsule.moveButton = true;
        avancerButton.interactable = false;
    }
    
    public void Lacher()
    {
        capsule.dropButton = true;
    }

    public void Pos1()
    {
        capsule.angle = 90;
        //capsule.rotation = new Vector3(0, 0, 0);
        capsule.rotate = true;
    }
    
    public void Pos2()
    {
        capsule.angle = 180;
        //capsule.rotation = new Vector3(0, 0, 90);
        capsule.rotate = true;
    }
    
    public void Pos3()
    {
        capsule.angle = -90;
        //capsule.rotation = new Vector3(0, 0, 180);
        capsule.rotate = true;
    }
    
    public void Pos4()
    {
        capsule.angle = 135;
        //capsule.rotation = new Vector3(0, 0, 45);
        capsule.rotate = true;
    }

    public void Para()
    {
        canvaPara.enabled = true;
        canva1.enabled = false;
    }

    public void Retour()
    {
        canvaPara.enabled = false;
        canva1.enabled = true;
    }
    
}
