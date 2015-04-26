using UnityEngine;
using System.Collections;
using System;
using SimpleJSON;
using AssemblyCSharp;

public class NetworkScript : MonoBehaviour {

	public ItemMenu im;
	public WebSocket w = new WebSocket (new Uri ("ws://192.168.8.15:3000"));

	public void SendMessage(string json) {
		w.SendString(json);
	}

	// Use this for initialization
	IEnumerator Start () {

		//WaresList waresList = new WaresList ();

		//Debug.Log ("TTzpe>  "+waresList.List.ToString ());
		
		yield return StartCoroutine(w.Connect());
		
		//w.SendString(waresList.List.ToString ());
		int i=0;
		
		while (true)
		{
			string reply = w.RecvString();
			
			if (reply != null)
			{
				
				Debug.Log ("Received: ");
				var receivedObject = JSON.Parse(reply);
				//w.SendString("Hi there"+i++);
				im.GetMessage(receivedObject);

				switch(receivedObject["msg"]) {
					case "list":
						//Debug.Log(receivedObject["msg"]);
						break;
				}

			}
			if (w.Error != null)
			{
				Debug.LogError ("Error: "+w.Error);
				break;
			}
			yield return 0;
		}
		
		w.Close();
		
	}
}
