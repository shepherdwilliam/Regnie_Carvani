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
		GameObject gc = GameObject.Find ("Character");
		Character ch = gc.GetComponent<Character> ();
		int n = cl.GetNumberOfChara();
		Debug.Log ("CardLibraryManager\nn : " + n);

		for (int i = 0; i < n; i++) {
			Debug.Log ("CardLibraryManager\n" + cl.GetCharaSerialData(i));
			string[] stch = cl.GetCharaSerialData (i);
			Debug.Log ("CardLibraryManager\n" + i + "回目");
			ch.test();
			ch.Setup (stch);
			publicCardLibrary.Add (ch);
			Debug.Log ("CardLibraryManager\n" + publicCardLibrary[i].displayName);
		}
	}
}
