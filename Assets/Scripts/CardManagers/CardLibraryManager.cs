using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLibraryManager : MonoBehaviour {

	static public List<Character> publicCardLibrary;
	public List<Character> playerCardLibrary;

	// Use this for initialization
	void Start () {
		publicCardLibrary = new List<Character> ();
		playerCardLibrary = new List<Character> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public Character GetCharacterById (int id) {
        Character c;
        //c = GetComponent<Character>();  
        Debug.Log("GetCharaById\n" + publicCardLibrary.Count);
        c = null;
        c = publicCardLibrary[id];//取得!ここでバグってるのでは？
        return c;
	}

	public void CreateLibrary (){
		
		GameObject c = GameObject.Find ("CardLoader");
		CardLoader cl = c.GetComponent<CardLoader> ();
		GameObject gc = GameObject.Find ("Character");
		Character ch = gc.GetComponent<Character> ();
		int n = cl.GetNumberOfChara(); //何人いるか？
		Debug.Log ("CardLibraryManager\nn : " + n);

		for (int i = 0; i < n; i++) {
            // i番目のキャラクターをpublicCardLibraryのi個目に入れる
            // stchはキャラセットアップ用の配列
            // Debug.Log("i" + i);
			Debug.Log ("CardLibraryManager\n" + cl.GetCharaSerialData(i));
			string[] stch = cl.GetCharaSerialData (i);
			Debug.Log ("CardLibraryManager\n" + i + "回目");
            //読んでみる
			ch.Test();
			ch.Setup (stch);
			publicCardLibrary.Add (ch);
			Debug.Log ("CardLibraryManager\n" + publicCardLibrary[i].displayName);
		}
	}
}
