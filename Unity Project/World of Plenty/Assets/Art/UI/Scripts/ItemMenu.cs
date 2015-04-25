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
		//AddItem("brick", "Bricks", 0, 0, 0, "brick_img");
		//AddItem("drugs", "Drugs", 0, 0, 0, "drugs_img");
		AddItem("Anti-Rad Meds", "Stims", 0, 0, 0, "icon_antiradiation");
		AddItem("Geiger Counter", "Stims", 0, 0, 0, "icon_geiger");
		AddItem("Bush Knife", "Stims", 0, 0, 0, "icon_bushknife");
		AddItem("Pickaxe", "Stims", 0, 0, 0, "icon_pickaxe");
		AddItem("Fuel Can", "Stims", 0, 0, 0, "icon_fuelcan");
		AddItem("Bricks", "Stims", 0, 0, 0, "icon_bricks");

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
		var go = GameObject.Instantiate(TextElement);

		go.transform.SetParent(Items.transform);
		go.name = id;
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
}
