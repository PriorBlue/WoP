//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
namespace AssemblyCSharp
{
	public class Ware
	{
		public string name = "### undefined ###";
		public int priceDefault = 20;

		public Ware (string name, int priceDefault)
		{
			this.name = name;
			this.priceDefault = priceDefault;
		}
	}
	
	public class WaresList 
	{
		private Hashtable waresList = new Hashtable();

		public Hashtable List {
			get {
				return waresList;
			}
		}

		public WaresList()
		{
			Ware ware = new Ware("clay", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("brick", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("trash", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("scrap metal", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("metal", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("wood", 20);
			waresList.Add(ware.name, ware);
			
			ware = new Ware("sawn-off shotgun", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("bush knife", 20);
			waresList.Add(ware.name, ware);
				
			ware = new Ware("pick axe", 20);
			waresList.Add(ware.name, ware);
					
			ware = new Ware("empty fuel can", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("yellow slime", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("tin can", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("atomic cola", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("broken cell phone", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("copper", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("wire", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("electronic parts", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("radio", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("geiger counter", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("flax", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("textiles", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("tent", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("sneakers", 20);
			waresList.Add(ware.name, ware);

			ware = new Ware("anti radiation medication", 20);
			waresList.Add(ware.name, ware);

		}
	}

}
