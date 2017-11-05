using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResource : MonoBehaviour {

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
		labelGold.text = "GOLD : " + gold.ToString();
		labelCrystal.text = "CRYSTAL : " + crystal.ToString();
	}
}
