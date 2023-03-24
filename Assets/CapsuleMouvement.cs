using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapsuleMouvement : MonoBehaviour
{
    private Vector3 avance = new Vector3(0, 0, 1);

    //public Vector3 rotation = new Vector3();
    public float angle;
    public bool rotate = false;

    private bool gravity = false;

    public bool moveButton = false;
    public bool dropButton = false;
    
    public Button lacherButton;
    
    void Update()
    {
        if (moveButton)
        {
            goToTestZone();
        }

        if (dropButton)
        {
            lacher();
        }

        if (rotate)
        {
            rotateToPos();
        }
        
    }

    /*void rotateToPos()
    {
        if (this.transform.rotation.z <= angle)
        {
            print(this.transform.rotation.z);
            print(angle);
            this.transform.Rotate(0.1f * avance);
            //this.transform.rotation = new Quaternion(0, 0, angle, 0);
        }
    }*/
    
    void rotateToPos()
    {
        Quaternion desiredRotation = Quaternion.Euler(0, 0, angle);
        if (Quaternion.Angle(this.transform.rotation, desiredRotation) > 0.000000001f * angle)
        {
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, desiredRotation, 1f);
        }
        else
        {
            rotate = false;
        }
    }

    void goToTestZone()
    {
        if (this.transform.position.z < 10)
        {
            this.transform.Translate(0.1f * avance);
        }
        else
        {
            lacherButton.interactable = true;
        }
    }

    void lacher()
    {
        if (!gravity)
        {
            this.GetComponent<Rigidbody>().useGravity = true;
            gravity = true;
        }
    }
}
