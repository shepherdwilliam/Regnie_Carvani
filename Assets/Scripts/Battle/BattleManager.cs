using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Test() {
        //キャラ入れ
        Character[] playerCards = new Character[6];
        Character[] enemyCards = new Character[6];
        GameObject c = GameObject.Find("CardLibraryManager");
        CardLibraryManager manager = c.GetComponent<CardLibraryManager>();
        for (int i = 0; i <= playerCards.Length; i++) {
            playerCards[i] = manager.GetCharacterById(0);
            playerCards[i] = manager.GetCharacterById(0);
        }
        //
        BattleGroup battleGroup = new BattleGroup();
        battleGroup = BattleElementFunction(playerCards, enemyCards);
        
        for (int i = 0; i <= battleGroup.playerCards.Length; i++){
            Debug.Log("Battle" + battleGroup.playerCards[i].name);
        }
    }

	//character[] 2
	BattleGroup BattleElementFunction (Character[] playerCards, Character[] enemyCards) {
		//各キャラクターの計算
		for (int i=0; i <= 6; i++){
			playerCards [i].hp = playerCards [i].hp - enemyCards [i].ap;
		}
        BattleGroup battleGroup = new BattleGroup();
        battleGroup.playerCards.CopyTo (playerCards, 0);
        battleGroup.enemyCards.CopyTo (enemyCards, 0);
        return battleGroup;
    }
}

public struct BattleGroup{
	public Character[] playerCards;
	public Character[] enemyCards;
}
