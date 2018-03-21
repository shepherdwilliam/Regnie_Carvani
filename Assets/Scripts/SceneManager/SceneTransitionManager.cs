using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MessageBattle(){
		Debug.Log ("SceneTransitionManager\n(Battle)のメッセージを受け取りました");
		SceneManager.LoadScene ("Battle");
	}

	public void MessageSummon(){
		Debug.Log ("SceneTransitionManager\n(Summon)のメッセージを受け取りました");
		SceneManager.LoadScene ("Summon");
	}

	public void MessageDictionary(){
		Debug.Log ("SceneTransitionManager\n(Dictionary)のメッセージを受け取りました");
		SceneManager.LoadScene ("Dictionary");
	}

	public void MessageStore(){
		Debug.Log ("SceneTransitionManager\n(Store)のメッセージを受け取りました");
		SceneManager.LoadScene ("Store");
	}
}
