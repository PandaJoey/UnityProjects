using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

    public int power;
    public int magicPower;
    public int defence;
    public int restored;
    public int damageBlocked;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void healingPotion(int restored) {
        int healthPot = 10;
        restored = healthPot;
    }

    void manaPotion(int restored) {
        int manaPot = 10;
        restored = manaPot;
    }

    void sword(int power) {
        int weaponDamage = 10;
        power = weaponDamage;
    }

    void sheild(int defence, int damageBlocked) {
        int sheildBlock = 10;
        int sheildDefence = 10;
        damageBlocked = sheildBlock;
        defence = sheildDefence;

    }

    void staff(int magicPower) {
        int staffPower = 10;
        magicPower = staffPower;
    }

    void wand(int magicPower) {
        int wandPower = 10;
        magicPower = wandPower;

    }

    void platemail(int defence) {
        int plateDefence = 20;
        defence = plateDefence;

    }

    void robes(int defence) {
        int robeDefence = 5;
        defence = robeDefence;
    }

    void plateHelm(int defence) {
        int helmDefence = 20;
        defence = helmDefence;

    }
    
}
