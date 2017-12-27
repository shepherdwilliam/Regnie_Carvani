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

	public void CreateLibrary (){
		int n = 1;
		GameObject c = GameObject.Find ("CardLoader");
		CardLoader cl = c.GetComponent<CardLoader> ();
		for (int i = 0; i < n; i++) {
			publicCardLibrary.Add (new Character(cl.GetCharaSerialData(i)));
			Debug.Log ("CardLibraryManager\n"+cl.GetCharaSerialData(i));
		}
	}
}
