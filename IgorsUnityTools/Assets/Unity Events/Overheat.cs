using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyFloatEvent : UnityEvent<float> { }

[System.Serializable]
public class MyMultuParamEvent : UnityEvent<float, Vector3, Overheat, Transform> { }

public class Overheat : MonoBehaviour
{

    public float heat = 0f;

    public MyFloatEvent onHeatChange;
    public MyMultuParamEvent onStuffChange;

    // Use this for initialization
    void Start () {
        onHeatChange.AddListener(MyHeatISLoud);
        onStuffChange.AddListener(MyStuffISLoud);
	}

    // Update is called once per frame
    void Update ()
	{
	    heat += Time.deltaTime * 0.2f;
	    onHeatChange.Invoke(heat);
	    onStuffChange.Invoke(heat, transform.position, this, transform);

        if (heat > 1)
	    {
            Destroy(gameObject);
	    }

	}

    public void MyStuffISLoud(float heat, Vector3 v, Overheat o, Transform t)
    {
        Debug.Log(name + " AAAAA " + heat);
    }

    public void MyHeatISLoud(float heat)
    {
        Debug.Log(name + " AAAAA " + heat);
    }
}
