using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour {

    public void Launch(Vector3 transformForward)
    {
        Debug.Log("Launching the Missle");
    }

    public void SetTarget(Transform target)
    {
        Debug.Log("Setting the Missle Target");
    }
}
