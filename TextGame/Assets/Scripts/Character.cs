using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public List<Items> backpack = new List<Items>();
    public List<Items> weapon = new List<Items>();
    public Items[] item = new Items[] { };
    public Items[] armour = new Items[] { };
    public int[] spells = new int[] { }; 
    public int health = 50;
    public int mana = 50;
	// Use this for initialization

    void Start () {
        //characterProfile(Items[] backpack, Items[] weapon, Items[] armour, Items[] item, int health, int mana, int[] spells);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void characterProfile(Items[] backpack, Items[] weapon, Items[] armour, Items[] item, int health, int mana, int[] spells) {
        int charHealth = health;
        int charMana = mana;
        int[] charSpells = spells;
        Items[] charInv = backpack;
        Items[] charWep = weapon;
        Items[] charArmour = armour;
        Items[] charItems = item;
    }
}
