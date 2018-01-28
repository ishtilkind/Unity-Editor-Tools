using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public FloatReference currentHp;
    public FloatReference maxHp;
    public FloatReference moveSpeed;

    // Use this for initialization
    void Awake () {
        currentHp.Value = maxHp.Value;

    }
	
	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown(0))
        {
            currentHp.Value--;
        }
	}
}
