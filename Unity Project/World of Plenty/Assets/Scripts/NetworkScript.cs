using UnityEngine;
using System.Collections;
using System;
using SimpleJSON;
using AssemblyCSharp;

public class NetworkScript : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {

		WaresList waresList = new WaresList ();

		Debug.Log ("TTzpe>  "+waresList.List.ToString ());

		
		WebSocket w = new WebSocket (new Uri ("ws://localhost:3000"));
		
		yield return StartCoroutine(w.Connect());
		
		w.SendString(waresList.List.ToString ());
		int i=0;
		
		while (true)
		{
			string reply = w.RecvString();
			
			if (reply != null)
			{
				
				Debug.Log ("Received: ");
				var receivedObject = JSON.Parse(reply);
				Debug.Log(receivedObject["item"]["name"]);
				w.SendString("Hi there"+i++);

				switch(receivedObject["event"]) {

					case "connected": 


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
