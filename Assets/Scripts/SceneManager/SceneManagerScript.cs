using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public interface ICustomMessageTarget : IEventSystemHandler{
	// メッセージングシステムを通して呼び出される関数
	void Battle();
	void Summon();
}

public class SceneManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MessageBattle(){
		Debug.Log ("Message 1 received");
		SceneManager.LoadScene ("Battle");
	}

	public void MessageSummon(){
		Debug.Log ("Message 2 received");
		SceneManager.LoadScene ("Summon");
	}

	public void MessageDictionary(){
		Debug.Log ("Message 3 received");
		SceneManager.LoadScene ("Dictionary");
	}

	public void MessageStore(){
		Debug.Log ("Message 4 received");
		SceneManager.LoadScene ("Store");
	}
}
