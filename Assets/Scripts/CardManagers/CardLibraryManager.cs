using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLibraryManager : MonoBehaviour {

	static public List<Character> publicCardLibrary;
	static public List<Character> playerCardLibrary;

	// Use this for initialization
	void Start () {
		publicCardLibrary = new List<Character> ();
		playerCardLibrary = new List<Character> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

    // idに対応するキャラクター(Character型)を返す
	public Character GetCharacterById (int id) {
        Character c;
        // Debug.Log("GetCharaById\npublicCardLibraryの要素数 : " + publicCardLibrary.Count);
        c = null;
        c = publicCardLibrary[id];
        return c;
	}

    // ライブラリの構成を行う
	public void CreateLibrary (){
		Debug.Log ("CardLibraryManager\nライブラリを構成します。");
		GameObject c = GameObject.Find ("CardLoader");
		CardLoader cl = c.GetComponent<CardLoader> ();
		GameObject gc = GameObject.Find ("Character");
		Character ch = gc.GetComponent<Character> ();
		int n = cl.GetNumberOfChara(); // 何人いるか？
		Debug.Log ("CardLibraryManager\nキャラクタ－要素数 : " + n);

		for (int i = 0; i < n; i++) {
            // i番目のキャラクターをpublicCardLibraryのi個目に入れる
			string[] stch = cl.GetCharaSerialData (i); // キャラセットアップ用の配列
            ch.Setup (stch);
			publicCardLibrary.Add (ch);
			Debug.Log ("CardLibraryManager\n" + publicCardLibrary[i].displayName);
		}
		Debug.Log ("CardLibraryManager\nライブラリの構成が完了しました。");
	}
}
