using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {
    static public List<Character> playerCards;
    static public List<Character> enemyCards;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Test() {
        //キャラ入れ
        playerCards = new List<Character> ();
        enemyCards = new List<Character> ();
        GameObject loader = GameObject.Find(name: "CardLoader");
        CardLoader cardLoader = loader.GetComponent<CardLoader>();
        cardLoader.Initialize();
        GameObject c = GameObject.Find(name: "CardLibraryManager");
        CardLibraryManager manager = c.GetComponent<CardLibraryManager>();
        Debug.Log("PlayerCards.Count\n手札の長さ" + playerCards.Count);
        for (int i = 0; i < 6; i++) {
            playerCards[i] = manager.GetCharacterById(id: 0);//できてる？
            enemyCards[i] = manager.GetCharacterById(id: 0);
            Debug.Log("Playerの" + i + "人目のカード\n" + playerCards[i].name);
            Debug.Log("Enemyの" + i + "人目のカード\n" + enemyCards[i].name);
        }

        
        BattleGroup battleGroup = new BattleGroup();
        battleGroup = BattleElementFunction(playerCards, enemyCards);//1
        battleGroup = BattleElementFunction(enemyCards, playerCards);//2

        for (int i = 0; i < battleGroup.defender.Count; i++) {
            Debug.Log("Battle" + battleGroup.defender[i].name);
        }
        for (int i = 0; i < battleGroup.attacker.Count; i++) {
            Debug.Log("Battle" + battleGroup.attacker[i].name);
        }
    }

	//character[] 2
	BattleGroup BattleElementFunction (List<Character> defensiveCards, List<Character> aggressiveCards) {
		//各キャラクターの計算
		for (int i=0; i < 6; i++){
            defensiveCards[i].hp = defensiveCards[i].hp - aggressiveCards[i].ap;
		}
        BattleGroup stGroup = new BattleGroup();
        stGroup.defender = defensiveCards;
        stGroup.attacker = aggressiveCards;
        return stGroup;
    }
}

public struct BattleGroup{
	public List <Character> defender;
	public List <Character> attacker;
}
