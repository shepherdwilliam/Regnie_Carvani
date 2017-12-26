using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class CardLoader : MonoBehaviour {

	TextAsset csvFile; // CSVファイル
	string csvStr; //CSVString
	string[] csvLines; //行ごとの配列
	string[] csvData; //完成データ



	// Use this for initialization
	void Start () {
		Debug.Log ("CardLoader\ninitializing...");
		Load ();
		Debug.Log ("CardLoader\ncomplete");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Load () {
		csvFile = Resources.Load("charadata") as TextAsset; //リソースからロード
		csvStr = Encoding.UTF8.GetString (csvFile.bytes); //ASCIIに変換
		csvLines = csvStr.Split('\n'); //改行で区切る

		for (int i = 0; i < csvLines.Length; i++) {
			// "//"でエスケープ
			if (csvLines[i].Split(',')[0].StartsWith("//")) {
				continue;
			}
			if (csvLines[i].Split(',')[0].StartsWith("%%")) {
				break;
			}

			csvData = csvLines[i].Split(','); //カンマで区切る
		}
		Debug.Log ("CardLoader\n" + csvData[2]);
	}

	public string[] GetCsvData () {
		Load ();
		return csvData;
	}
}