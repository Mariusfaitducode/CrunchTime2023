using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustCapsule : MonoBehaviour
{
    public GameObject capsule;

    public void capsuleUp()
    {
        transform.Translate(new Vector3(0,0.1f,0));
    }
    
    public void capsuleDown()
    {
        transform.Translate(new Vector3(0,-0.1f,0));
    }


    public void angleUp()
    {
        capsule.transform.Rotate(new Vector3(0,0,1f));
    }
    
    public void angleDown()
    {
        capsule.transform.Rotate(new Vector3(0,0,-1f));
    }
}
