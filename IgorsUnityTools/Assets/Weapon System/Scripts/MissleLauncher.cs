using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLauncher : MonoBehaviour, ILauncher
{
    [SerializeField] private Missle misslePrefab;

    public void Launch(Weapon weapon)
    {
        Transform target = FindObjectOfType<Transform>();
        var missle = Instantiate(misslePrefab);
        //missle.Launch(weapon.transform.forward);
        missle.SetTarget(target);
    }
}
