using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class DrawScript : MonoBehaviour {

	public TextAsset xmlTextAsset;
	public XmlDocument xmlDoc = new XmlDocument();


	// Use this for initialization
	void Start () {
		xmlDoc.LoadXml(xmlTextAsset.text);
		XmlNodeList nodes = xmlDoc.GetElementsByTagName("chara");
		foreach (XmlNode node in nodes) {
		// get sorted xml elements
			Debug.Log("id : " + node.Attributes.GetNamedItem("id").Value);
			XmlNode childNode = node.FirstChild;
			int count = 0;
			do {
				if (++count > 8) break;
				// Count for 8
				Debug.Log(childNode.Name + " : " + childNode.FirstChild.Value);
			} while ((childNode = childNode.NextSibling) != null);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
