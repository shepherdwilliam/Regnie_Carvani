using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MessageBattle(){
		Debug.Log ("Message (Battle) received");
		SceneManager.LoadScene ("Battle");
	}

	public void MessageSummon(){
		Debug.Log ("Message (Summon) received");
		SceneManager.LoadScene ("Summon");
	}

	public void MessageDictionary(){
		Debug.Log ("Message (Dictionary) received");
		SceneManager.LoadScene ("Dictionary");
	}

	public void MessageStore(){
		Debug.Log ("Message (Store) received");
		SceneManager.LoadScene ("Store");
	}
}
