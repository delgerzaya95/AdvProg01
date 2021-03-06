﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
	public List<Item> itemList = new List<Item>();
	void Start()
	{
		itemList.Add (new Item ("Stapler Gun 00", 0, 
			"A custom-modeled stapler-gun which gives the ability to staple papers from distance, WOW!", 
			1, 1, Item.ItemType.Weapon, Item.DropType.None));
		itemList.Add (new Item ("Stamper Gun 00", 1, " gives the ability to staple papers from distance, WOW! ", 
			1, 1, Item.ItemType.Weapon, Item.DropType.None));
		itemList.Add (new Item ("Work Outfit 00", 2,  "A typical formal wear for work", 
			1, 1, Item.ItemType.Outfit, Item.DropType.None));
		itemList.Add(new Item("Small Health Potion", 3, "Potion to regain some health", 
			15, 0, Item.ItemType.Consumable, Item.DropType.ConsumeOnUse));
		//0 - 9 - weapons //
		//10 ~ 19 outfir //
		//20 ~ 30 consumables //

		itemList.Add(new Item("Small Vitality Radiation", 29, "Left-over radiation of vital energy. Pick to regain some health", 
			5, 0, Item.ItemType.Consumable, Item.DropType.ConsumeOnPick));
		itemList.Add(new Item("Small Energy Radiation", 30, "Left-over radiation of energy. Pick to regain some energy", 
			5, 0, Item.ItemType.Consumable, Item.DropType.ConsumeOnPick));
	}
}
