using UnityEngine;

public class BattleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Test() {
        // キャラ入れ
        Character[] playerCards = new Character[6];
        Character[] enemyCards = new Character[6];
        GameObject loader = GameObject.Find(name: "CardLoader");
        CardLoader cardLoader = loader.GetComponent<CardLoader>();
		cardLoader.Initialize();
        GameObject c = GameObject.Find(name: "CardLibraryManager");
        CardLibraryManager manager = c.GetComponent<CardLibraryManager>();
        Debug.Log("BattleManager\nPlayerCardsLength : " + playerCards.Length);
		Debug.Log ("BattleManager\n手札チェック");
        // 代入
		for (int i = 0; i < playerCards.Length; i++) {
            playerCards[i] = manager.GetCharacterById(id: 0);
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

	// character[]x2
	BattleGroup BattleElementFunction (Character[] defenderCards, Character[] attackerCards) {
		// 各キャラクターの計算
		for (int i=0; i < 6; i++){
            defenderCards[i].hp = defenderCards[i].hp - attackerCards[i].ap;
		}
        defenderCards.CopyTo (array: new BattleGroup().defender, index: 0x0);
        attackerCards.CopyTo (array: new BattleGroup().attacker, index: 0x0);
        return new BattleGroup();
    }
}

// キャラクター配列二つの型
public struct BattleGroup{
	public Character[] defender;
	public Character[] attacker;
}
