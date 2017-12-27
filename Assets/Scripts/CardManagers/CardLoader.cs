using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class CardLoader : MonoBehaviour {

	TextAsset csvFile; // CSVファイル
	string csvStr; //CSVString
	string[] csvLines; //行ごとの配列
	public string[][]  csvData; //完成データ[i][j] i:キャラクター、j:各値

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
		int i = 0;
		int nullcount =0;

		try {
			Debug.Log(csvLines[0]+"\n"+csvLines[1]);
		}
		catch {
			Debug.Log("CardLoader\nCSV is null");
		}

		while (i + nullcount < csvLines.Length) {
			// "//"でエスケープ
			Debug.Log ("CardLoader\nescaping...");
			if (csvLines[i+nullcount].Split(',')[0].StartsWith("//")) {
				nullcount ++;
				Debug.Log ("CardLoader\nescaped - nullcount : " + nullcount);
				Debug.Log (csvLines[i+nullcount].Split(',')[0]);
				continue;
			}
			if (csvLines[i+nullcount].Split(',')[0].StartsWith("%%")) {
				Debug.Log ("CardLoader\nEnd of File");
				Debug.Log (csvLines[i].Split(',')[0]);
				break;
			}
			//空白でない行が実行される
			//ここら辺に
			csvData[i] = new string[11];
			Debug.Log ("CardLoader\ncsvLines" + csvLines[i]);
			csvData[i] = csvLines[i].Split (',');
			Debug.Log ("CardLoader\ncsvData[j][0]" + csvData[i][0]);
			i++;
		}
		csvData = new string[i][];

		for (int j = 0; j < i;j++) {
			
		}
		Debug.Log ("CardLoader\n" + csvData[1][0] + csvData[1][1] + csvData[1][2] + csvData[1][3]);
	}

	public string[][] GetCsvData () {
		return csvData;
	}


	//キャラクター単体のStringを返す
	public string[] GetCharaSerialData (int id) {
		string[] str = new string[11];
		Debug.Log ("CardLoader:GetCharaSerialData" + csvData[id][0]);
		str = csvData[id];
		return str;
	}
}