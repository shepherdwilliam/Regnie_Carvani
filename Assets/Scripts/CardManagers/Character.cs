using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

public class Character : MonoBehaviour {

	public int id;	// ID
	new public string name;	// 名前
	public string displayName;	// 表示用の名前
	public string description; //説明
	public string nation; //国家
	public int hp; // HP
	public int ap; // AP
	public bool playerCard;

	public void test () {
		Debug.Log ("Character : test\n");
	}
	public void Setup (string[] str) {
		id = int.Parse(str[0]);
		name = str [1];
		displayName = str [2];
		description = str [3];
		nation = str [4];
		hp = int.Parse(str[7]);
		ap = int.Parse(str[8]);
		/*if (str [12] == "1") {
			//HAVEIT
			playerCard = true;
		} else {
			playerCard = false;
		}*/
		Debug.Log ("Character : Setup\nid : " + id);
	}
}
