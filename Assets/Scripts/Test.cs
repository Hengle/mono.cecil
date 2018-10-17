using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInjectAttribute:Attribute
{

}

public class Normal
{
    public static int GetMax(int a,int b)
    {
        Debug.LogFormat("a={0},b={1}", a, b);
        return a > b ? a : b;
    }
}

[TestInject]
public class Inject
{
    public static int GetMax(int a,int b)
    {
        return a;
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Debug.LogFormat("Normal Max:{0}",Normal.GetMax(6,9));
        Debug.LogFormat("Inject Max:{0}", Inject.GetMax(6, 9));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
