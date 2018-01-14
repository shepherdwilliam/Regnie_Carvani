﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class CardLoader : MonoBehaviour {

	/* CSV 仕様
	//Character Data Csv,,,,,,,,,,
	//id,//name,//display name,//description,//nation,//def hp,//max hp,//def ap,//max ap,//hp,//ap
	%%,,,,,,,,,,
	*/

	TextAsset csvFile; // CSVファイル
	string csvStr; //CSVString
	public string[] csvLines; //行ごとの配列 .Length がキャラクター数

	//public string[][]  csvData; //完成データ[i][j] i:キャラクター、j:各値

	// Use this for initialization
	void Start () {
		Debug.Log ("CardLoader\ninitializing...");
		Load ();
		GameObject c = GameObject.Find ("CardLibraryManager");
		CardLibraryManager cl = c.GetComponent<CardLibraryManager> ();
		cl.CreateLibrary ();
		Debug.Log ("CardLoader\ncomplete");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Load () {
		csvFile = Resources.Load("charadata") as TextAsset; //リソースからロード
		csvStr = Encoding.UTF8.GetString (csvFile.bytes); //ASCIIに変換
		csvLines = csvStr.Split('\n'); //改行で区切る

		/*
		int i = 0;
		int nullcount =0;
		for (int l = 0; l < csvLines.Length; l ++) {
			Debug.Log("CardLoader : csvLines[" + l + "]\n" + csvLines[l]);
		}


		bool[] lines =new bool[csvLines.Length];

		while (i + nullcount < csvLines.Length) {
			Debug.Log ("CardLoader\nescaping...");
			//コメントか否か
			if (csvLines[i+nullcount].Split(',')[0].StartsWith("//")) {
				Debug.Log ("CardLoader ESCAPED\ncsvLines[" + (i + nullcount) + "]");
				Debug.Log ("CardLoader\n" + csvLines[i+nullcount].Split(',')[0]);
				lines [i + nullcount] = false; //行はコメント
				nullcount ++;
				continue;
			}
			//ファイルの最後
			if (csvLines[i+nullcount].Split(',')[0].StartsWith("%%")) {
				Debug.Log ("CardLoader\nEnd of File : " + csvLines[i+nullcount].Split(',')[0]);
				lines [i + nullcount] = false; //行はコメント
				break;
			}

			Debug.Log ("CardLoader\nline " + (i + nullcount) + " is not a comment");
			Debug.Log ("CardLoader\ncsvLines[" + (i + nullcount) + "] is " + csvLines[i + nullcount]);
			lines [i + nullcount] = true; //行はコメントではない
			i++;
		}

		csvData = new string[i][];


		for (int j = 0; j < i + nullcount; j++) {
			Debug.Log ("CardLoader\nline " + j + " is " + lines[j]);
			if (lines[j] == true){
				Debug.Log ("CardLoader\nAssert");
				csvData[j] = new string[10];
				csvData[j] = csvLines[j].Split (',');
				Debug.Log ("CardLoader\ncsvLines : " + csvLines[j]);
				Debug.Log ("CardLoader\ncsvData[j][0] : " + csvData[j][0]);
			}
		}
		*/
	}

	//キャラクター単体のString[]を返す
	public string[] GetCharaSerialData (int id) {
		Debug.Log ("CardLoader\nGCSD id : " + id);
		Debug.Log ("CardLoader\nGCSD lines name : " + csvLines[id].Split (',')[1]);
		return csvLines[id].Split (',');
	}

	public int GetNumberOfChara () {
		return csvLines.Length;
	}
}