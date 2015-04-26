using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemMenu : MonoBehaviour {

	public GameObject Items;
	public GameObject TextElement;
	public Sprite[] spriteList;

	private GameObject[] items;

	// Use this for initialization
	void Start () {
		AddItem("geiger", "Geiger", 99, 7, 9, "icon_geiger");
		AddItem("antiradiation", "Antiradiation", 7, 120, 140, "icon_antiradiation");
		AddItem("template", "Template", 900, 11, 14, "icon_template");
		AddItem("bushknife", "Bushknife", 999, 3, 4, "icon_bushknife");
		AddItem("pickaxe", "Pickaxe", 99, 1, 2, "icon_pickaxe");
		AddItem("bricks", "Bricks", 999, 1, 2, "icon_bricks");
		AddItem("fuelcan", "Fuelcan", 999, 1, 2, "icon_fuelcan");

		//SetAmount("drugs", 99);
		//SetSellPrice("drugs", 3);
		//SetBuyPrice("drugs", 5);

		//ClearItems ();

		//AddItem("lol", "LOL");
		//SetImage("lol", "lol");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddItem(string id, string name = "None", int amount = 0, int sell = 0, int buy = 0, string image = "none"){
		GameObject go = GameObject.Instantiate(TextElement);
		ItemSingle itm = go.GetComponent<ItemSingle> ();

		go.transform.SetParent(Items.transform);
		go.name = id;
		SetItem(id, name, amount, sell, buy, image);

		BindButton (id, itm.sell1, "sell1");
		BindButton (id, itm.sell10, "sell10");
		BindButton (id, itm.sell100, "sell100");

		BindButton (id, itm.buy1, "buy1");
		BindButton (id, itm.buy10, "buy10");
		BindButton (id, itm.buy100, "buy100");
	}

	public void SetItem(string id, string name, int amount, int sell, int buy, string image){
		SetName (id, name);
		SetImage (id, image);
		SetAmount (id, amount);
		SetSellPrice (id, sell);
		SetBuyPrice (id, buy);
	}

	public void SetName(string id, string name){
		Items.transform.FindChild (id).GetComponent<ItemSingle> ().name.text = name;
	}

	public void SetImage(string id, string name){
		for (int i = 0; i < spriteList.Length; i++) {
			if(spriteList[i].name == name){
				Items.transform.FindChild (id).GetComponent<ItemSingle> ().icon.sprite = spriteList [i];
				break;
			}
		}
	}

	public void SetAmount(string id, int amount){
		Items.transform.FindChild (id).GetComponent<ItemSingle> ().amount.text = amount.ToString();
	}

	public void SetSellPrice(string id, int sell){
		Items.transform.FindChild (id).GetComponent<ItemSingle> ().sell.text = "$" + sell.ToString();
	}

	public void SetBuyPrice(string id, int buy){
		Items.transform.FindChild (id).GetComponent<ItemSingle> ().buy.text = "$" + buy.ToString();
	}

	public void ClearItems(){
		for (int i = 0; i < Items.transform.childCount; i++) {
			Destroy(Items.transform.GetChild(i).gameObject);
		}
	}

	public void BindButton(string id, Button btn, string action){
		btn.onClick.AddListener (delegate {
			Debug.Log(id + ": " + action);
		});
	}
}
