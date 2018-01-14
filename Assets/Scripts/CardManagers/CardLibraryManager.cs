using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLibraryManager : MonoBehaviour {

	public List<Character> publicCardLibrary;
	public Character[] playerCardLibrary;

	// Use this for initialization
	void Start () {
		publicCardLibrary = new List<Character> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void test () {
		
	}

	public void CreateLibrary (){
		
		GameObject c = GameObject.Find ("CardLoader");
		CardLoader cl = c.GetComponent<CardLoader> ();
		int n = cl.GetNumberOfChara();
		Debug.Log ("CardLibraryManager\nn : "+n);

		for (int i = 0; i < n; i++) {
			Debug.Log ("CardLibraryManager\nloop : "+i);
			Debug.Log ("CardLibraryManager\n"+cl.GetCharaSerialData(i));
			string[] stch = cl.GetCharaSerialData (i);
			Character ch = new Character[stch];
			publicCardLibrary.Add (ch);
		}
	}
}
