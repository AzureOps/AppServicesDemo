﻿using System.Collections;
using System.Collections.Generic;
using System;

public class Inventory
{
	public string id { get; set; }

	public int strawberries { get; set; }
	public int melons { get; set; }
	public int lemons { get; set; }
	public int medicine { get; set; }

	public Inventory() {
		this.strawberries = 0;
		this.melons = 0;
		this.lemons = 0;
		this.medicine = 0;
	}

	public override string ToString()
	{
		return string.Format("id: {0} inventory: {1},{2},{3},{4}", id, strawberries, melons, lemons, medicine );
	}

	/*
	/// <summary>
	/// Factory method to create empty inventory
	/// </summary>
	public static Inventory Create() {
		Inventory inventory = new Inventory ();
		inventory.strawberries = 0;
		inventory.melons = 0;
		inventory.lemons = 0;
		inventory.medicine = 0;
		return inventory;
	}
	*/
}