using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class CardLoader : MonoBehaviour {

	/* CSV 仕様
     * id,name,display name,description,nation,def hp,max hp,def ap,max ap,hp,ap
     */


	TextAsset csvFile; // CSVファイル
	string csvStr; // CSVString
	public string[] csvLines; // 行ごとの配列 .Length がキャラクター数

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // CSVファイルからの読み込み
	public void Load () {
		csvFile = Resources.Load("charadata") as TextAsset; // リソースからロード
		csvStr = Encoding.UTF8.GetString (csvFile.bytes); // ASCIIに変換
		csvLines = csvStr.Split('\n'); // 改行で区切る
	}

	// idに対応するキャラクター単体のString[]を返す
	public string[] GetCharaSerialData (int id) {
		return csvLines[id].Split (',');
	}

    // CSVファイルの行数(Character数)を返す
	public int GetNumberOfChara () {
		return csvLines.Length;
	}

    // カードの初期化を行う
	public void Initialize(){
        Debug.Log("CardLoader\n初期化を開始しています...");
        Load();
        GameObject c = GameObject.Find("CardLibraryManager");
        CardLibraryManager cl = c.GetComponent<CardLibraryManager>();
        cl.CreateLibrary();
        Debug.Log("CardLoader\n初期化が完了しました。");
    }
}