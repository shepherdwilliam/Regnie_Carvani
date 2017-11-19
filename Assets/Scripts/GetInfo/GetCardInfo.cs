using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.EventSystems;

public class GetCardInfo : MonoBehaviour {

	//public TextAsset xmlTextAsset;
	//public XmlDocument document = new XmlDocument();

	// Use this for initialization
	void Start () {
		/*
		foreach( XmlElement element in document.DocumentElement ){
			string text = element.InnerText;                         // 要素の内容
			string attribute = element.GetAttribute( "attribute" );  // 属性
			Debug.Log (text);
			Debug.Log (attribute);
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GetCardName (int id){
		Debug.Log (id);
	}
}
