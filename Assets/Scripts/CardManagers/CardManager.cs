using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

public class Character{
	public Character(string[] str) {
		id = int.Parse(str[0]);
		name = str [1];
		displayName = str [2];
		description = str [3];
		nation = str [4];
		hp = int.Parse(str[7]);
		ap = int.Parse(str[8]);
	}

	public Character(int pid) {
		id = pid;
		CardLoader c = CardLoader.GetComponent<CardLoader>;
		string[] str = c.GetCsvData ();
		name = str [1];
		displayName = str [2];
		description = str [3];
		nation = str [4];
		hp = int.Parse(str[7]);
		ap = int.Parse(str[8]);
	}

	public int id;	// ID
	public string name;	// 名前
	public string displayName;	// 表示用の名前
	public string description; //説明
	public string nation; //国家
	public int hp; // HP
	public int ap; // AP
}
/*CardManager
 * カードの管理
*/
public class CardManager : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*------------------------------------------------------------*
	 *              機能たち - "call him!"                        *
	 * -----------------------------------------------------------*/

	//IDで指定されたカード(キャラクター)の指定された情報を返す
	public string GetCardInfo (int id, int mode){
		string str = "";
		switch(mode) {
		case 0:
			//do nothing
			break;

		case 1:
			//return name

			break;

		case 2:
			//return display name

			break;

		case 3:
			//return description

			break;

		case 4:
			//return nation
			break;

		default :
			//do nothing
			break;
		}
		return str;
	}

	//IDで指定されたカード(キャラクター)のHP,APを返す
	public int GetDefCardPoint (int id, int mode){
		int point = 0;
		switch(mode) {
		case 0:
			//return hp

			break;

		case 1:
			//return ap

			break;
		
		default :
			//do nothing
			break;
		}
		return point;
	}

	public int GetCardPoint (int id, int mode){
		int point = 0;
		switch(mode) {
		case 0:
			//return hp

			break;

		case 1:
			//return ap

			break;

		default :
			//do nothing
			break;
		}
		return point;
	}
}
