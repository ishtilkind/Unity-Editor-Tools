using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;
    public void Launch(Vector3 dir)
    {
        Debug.Log("Launching the bullet");
        direction = dir;
    }

    void Update()
    {
        //transform.Translate(Vector3.right * Time.deltaTime, Camera.main.transform);
        transform.Translate(direction * Time.deltaTime, Space.World);
    }
}
