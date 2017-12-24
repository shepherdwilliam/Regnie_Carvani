using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{
	public int id;	// ID
	public string name;	// 名前
	public string displayName;	// 表示用の名前
	public string description;
	public string nation;
	public int hp;
	public int ap;
}

public class CardGroupManager : MonoBehaviour {

	public Character[] playerCards = new Character[6];	//プレイヤーの手札

	public Character[] enemyCards = new Character[6];	//敵の手札

	void Start () {
		//プレイヤー手札の情報の読み込み
		for(int i=0; i<playerCards.Length; ++i){
			playerCards[i].id = 0;	//ダミー
		}

		//敵の手札の読み込み
		for(int i=0; i<enemyCards.Length; ++i){
			enemyCards[i].id = 0;	//ダミー
		}
	}

	void Update () {
		
	}
}