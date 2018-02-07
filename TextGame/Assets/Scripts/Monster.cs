using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstor : MonoBehaviour {

    private int health;
    private int mana;
    private int defence;
    private int fireRes;
    private int iceRes;
    private int attackPower;
    private int magicPower;
    private int[] spells;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void gargoyle(int health, int mana, int defence, int fireRes, int iceRes, int attackPower, int magicPower, int[] spells) {

        int gHealth = 500;
        health = gHealth;

        int gMana = 500;
        mana = gMana;

        int gDefence = 50;
        defence = gDefence;

        int gFireRes = 100;
        fireRes = gFireRes;

        int gIceRes = 100;
        iceRes = gIceRes;

        int gAttackPower = 50;
        attackPower = gAttackPower;

        int gMagicPower = 300;
        magicPower = gMagicPower;
        

        // figure out how to add boss spells 

    }

    void bandits(int health, int mana, int defence, int fireRes, int iceRes, int attackPower, int magicPower, int[] spells) {

        int bHealth = 300;
        health = bHealth;

        int bMana = 100;
        mana = bMana;

        int bDefence = 200;
        defence = bDefence;

        int bFireRes = 0;
        fireRes = bFireRes;

        int bIceRes = 0;
        iceRes = bIceRes;

        int bAttackPower = 150;
        attackPower = bAttackPower;

        int bMagicPower = 0;
        magicPower = bMagicPower;
       

    }

    void tree(int health, int mana, int defence, int fireRes, int iceRes, int attackPower, int magicPower, int[] spells) {

        int tHealth = 500;
        health = tHealth;

        int tMana = 300;
        mana = tMana;

        int tDefence = 200;
        defence = tDefence;

        int tFireRes = -100;
        fireRes = tFireRes;

        int tIceRes = 0;
        iceRes = tIceRes;

        int tAttackPower = 100;
        attackPower = tAttackPower;

        int tMagicPower = 150;
        magicPower = tMagicPower;
        

    }

    void ooze(int health, int mana, int defence, int fireRes, int iceRes, int attackPower, int magicPower, int[] spells) {

        int oHealth = 50;
        health = oHealth;

        int oMana = 1000;
        mana = oMana;

        int oDefence = 1000;
        defence = oDefence;

        int oFireRes = 0;
        fireRes = oFireRes;

        int oIceRes = 100;
        iceRes = oIceRes;

        int oAttackPower = 10;
        attackPower = oAttackPower;

        int oMagicPower = 300;
        magicPower = oMagicPower;
        

    }
}
