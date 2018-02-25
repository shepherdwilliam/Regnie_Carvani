using UnityEngine;
using UnityEngine.UI;

public class PlayerResourceManager : MonoBehaviour {

	int gold;
	int crystal;
	public Text labelGold;
	public Text labelCrystal;

	// Use this for initialization
	void Start () {
		gold = 10000;
		crystal = 100000;
	}
	
	// Update is called once per frame
	void Update () {
		DrawText ();
	}


	//ラベルにゴールドとクリスタルの表示
	void DrawText () {
		labelGold.text = "GOLD : " + gold.ToString();
		labelCrystal.text = "CRYSTAL : " + crystal.ToString();
	}
}
