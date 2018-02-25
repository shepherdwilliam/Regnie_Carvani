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
        GameObject loader = GameObject.Find(name: "CardLoader");
        CardLoader cardLoader = loader.GetComponent<CardLoader>();
        cardLoader.Initialize();
        GameObject c = GameObject.Find(name: "CardLibraryManager");
        CardLibraryManager manager = c.GetComponent<CardLibraryManager>();
        Debug.Log("PlayerCardsLength\n" + playerCards.Length);
        for (int i = 0; i < playerCards.Length; i++) {
            playerCards[i] = manager.GetCharacterById(id: 0);//できてる？
            enemyCards[i] = manager.GetCharacterById(id: 0);
            Debug.Log("Playerの" + i + "人目のカード\n" + playerCards[i].name);
            Debug.Log("Enemyの" + i + "人目のカード\n" + enemyCards[i].name);
        }

        
        BattleGroup battleGroup = new BattleGroup();
        battleGroup = BattleElementFunction(playerCards, enemyCards);//1
        battleGroup = BattleElementFunction(enemyCards, playerCards);//2

        for (int i = 0; i < battleGroup.defender.Length; i++) {
            Debug.Log("Battle" + battleGroup.defender[i].name);
        }
        for (int i = 0; i < battleGroup.attacker.Length; i++) {
            Debug.Log("Battle" + battleGroup.attacker[i].name);
        }
    }

	//character[] 2
	BattleGroup BattleElementFunction (Character[] defenderCards, Character[] attackerCards) {
		//各キャラクターの計算
		for (int i=0; i < 6; i++){
            defenderCards[i].hp = defenderCards[i].hp - attackerCards[i].ap;
		}
        BattleGroup battleGroupCards = new BattleGroup();
        defenderCards.CopyTo (array: battleGroupCards.defender, index: 0x0);
        attackerCards.CopyTo (array: battleGroupCards.attacker, index: 0x0);
        return battleGroupCards;
    }
}

public struct BattleGroup{
	public Character[] defender;
	public Character[] attacker;
}
