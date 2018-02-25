using System.Collections;
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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Load () {
		csvFile = Resources.Load("charadata") as TextAsset; //リソースからロード
		csvStr = Encoding.UTF8.GetString (csvFile.bytes); //ASCIIに変換
		csvLines = csvStr.Split('\n'); //改行で区切る

	}

	//キャラクター単体のString[]を返す
	public string[] GetCharaSerialData (int id) {
		return csvLines[id].Split (',');
	}

	public int GetNumberOfChara () {
		return csvLines.Length;
	}

    public void Initialize(){
        Debug.Log("CardLoader\ninitializing...");
        Load();
        GameObject c = GameObject.Find("CardLibraryManager");
        CardLibraryManager cl = c.GetComponent<CardLibraryManager>();
        cl.CreateLibrary();
        Debug.Log("CardLoader\ncomplete");
    }
}