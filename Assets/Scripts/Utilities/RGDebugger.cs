using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGDebugger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void WriteArray(int[] array)
	{
		string Arr = "";
		for(int i=0; i<=array.Length; ++i)
		{
			Arr = Arr + array [i];
		}
		Debug.Log ("{"+ Arr  + "}\n");
	}
}
