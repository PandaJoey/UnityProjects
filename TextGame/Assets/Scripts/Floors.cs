using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floors : MonoBehaviour {

    public Text text;
    private enum States { kingdom, swamp, forest, undergroundPassage,
                          temple, dungeon, lake, plains, finalBoss,
                          restart, advance, swampBoss, forestBoss, templeBoss
                          , dungeonBoss
    };
    private States myState;
    private Monstor bandit;
    private Monstor tree;
    private Monstor ooze;
    private Monstor gargoyle;


    // Use this for initialization
    void Start() {
        myState = States.kingdom;
    }

    // Update is called once per frame
    void Update() {
        print(myState);
        if (myState == States.kingdom) {
            state_kingdom();
        }
        else if (myState == States.swamp) {
            state_swamp();
        }
        else if (myState == States.forest) {
            state_forest();
        }
        else if (myState == States.undergroundPassage) {
            state_undergroundPassage();
        }
        else if (myState == States.temple) {
            state_temple();
        }
        else if (myState == States.dungeon) {
            state_dungeon();
        }
        else if (myState == States.lake) {
            state_lake();
        }
       
        else if (myState == States.plains) {
            state_plains();
        }
        else if (myState == States.finalBoss) {
            state_finalBoss();
        }
        else if (myState == States.restart) {
            state_restart();
        }
        else if (myState == States.advance) {
            state_advance();
        }
        else if (myState == States.swampBoss) {
            state_swamp_boss();
        }
        else if (myState == States.templeBoss) {
            state_temple_boss();
        }
        else if (myState == States.forestBoss) {
            state_forest_boss();
        }
        else if (myState == States.dungeonBoss) {
            state_dungeon_boss();
        }

    }
    void state_kingdom() {
        text.text = "You are the kindoms hero and have just been summoned by your king " +
                    "He tells you that one of the kindoms rarest artifacts has been stolen " +
                    "The villan is Barry the Great Ogre, The most feared warrior in the land " +
                    "As the kindoms hero he asked you to go on a quest to find Barry " +
                    "Will you accept the kings Quest? " +
                    "Press N if you do not wish to take the quest " +
                    "Press Y if you will take the Kings quest ";
        if (Input.GetKeyDown(KeyCode.N)) {
            myState = States.restart;
        }
        else if (Input.GetKeyDown(KeyCode.Y)) {
            myState = States.advance;
        }
    }

    void state_swamp() {
        text.text = "You have decided to venture to the swamps, you get there " +
                    "You are met with the most foul stench imaginable " +
                    "The only way through is the wade into the swamp in " +
                    "You find a chest there are two items inside, you may select One Item " +
                    "Press Q to select the sword, or E to select the staff ";
        if (Input.GetKeyDown(KeyCode.Q)) {
            myState = States.swampBoss;
            // figure out how to select items
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            myState = States.swampBoss;
            // figure out how to select items
        }
    }
        void state_swamp_boss() { 
        // need to figure out a transition for this text
        text.text = "You now carry on wading through the swap when you notice " +
                    "The stench getting far worse, when out of nowhere a huge blob  " +
                    "like create appears infront of you what will you do? press R to run " +
                    "or A to attack ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.kingdom;
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            // figure out how to start a battle sequence
        }

    }
      

    void state_forest() {
        text.text = "So you chose to go into the forest, it feels darker than dark " +
                    "As you walk through the trees you hear noises you have never heard before " +
                    "Suddenly you are attacked, a tree has come to life and has started thrashing around " +
                    "What will you do? Press A to attack or R to run ";
        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.forestBoss;
            // figure out how to start a battle sequence
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.kingdom;
        }

    }

    void state_forest_boss() {
        text.text = "You decided to stay and fight the tree valiantly " +
                    "you defeated the boss you now have a choice " +
                    "Press T to move forward to the temple or D to move to the dungeons ";
    }

    void state_undergroundPassage() {
        text.text = "The Underground passage, leading from the castle to the outside" +
                    "What will await you hero as you travel through the underground " +
                    "As you walk throw the tunnels you see a passage glinting in the distance" +
                    "I seens you have stumbled apon the treasurey " +
                    "Inside you find Three new items These are a sheild platemail and a potion " +
                    "You Carry on through the tunnels when you are met with a choice " +
                    "To take the left pass Press L and the right R ";
        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.temple;
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.dungeon;
        }
    }

    void state_temple() {
        text.text = "After choosing to take the left path you arrive at what looks like a temple " +
                    "It is blindingly white and looks deserted, you venture inside and start to look " +
                    "Throught he rooms inside the temple. It feels strange how quiet it is you walk " +
                    "Towards the alter in the centre room and find a mana potion, The whole building " +
                    "Starts to shake, you look up and see a huge gargoyle looking create flying at you " +
                    "Press A to attack or R to run ";

        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.templeBoss;
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.undergroundPassage;
        }


    }

    void state_temple_boss() {
        text.text = "You engage in battle with the gargoyle, the temple starts to fall apart" +
                    "You run outside but the gargoyle follows you and battle continues ";
        //this is where in need to start a fighting state.

    }

    void state_dungeon() {
        text.text = "You arrive at the dungeon, for some reason there are no gaurds and " +
                    "All the cells are open, you assume the prision is just deserted" +
                    "As you make your way through the dungeon, you see a light at the end of" +
                    "The Passageway what will you do? press T to turn back or P to procced down" +
                    "The passageway.  ";
        if (Input.GetKeyDown(KeyCode.P)) {
            myState = States.dungeonBoss;
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.undergroundPassage;
        }

    }

    void state_dungeon_boss() {
        text.text = "You carry on down the passage way when you start to hear voices " +
                    "You get close to listen, you hear men talking about killing the guards " +
                    "What will you do, Press R to run in and attack or press S to try and" +
                    "Do a Stealth attack ";

        //start a fight here if successful go to the the desert
    }

    void state_lake() {
        text.text = "After vanquishing the great gargoyle your next stop seems to be a huge lake " +
                    "You find a boat and start to row across the lake, you notice a small opening " +
                    "In the cliff edge and row towards it. Once inside you find a chest," +
                    "You open the chest and find a plate helmet and a health tonic. You continue" +
                    "On until you arrive at a huge castle Press C to continue ";
        if(Input.GetKeyDown(KeyCode.C)) {
            myState = States.finalBoss;
        }
    }


    void state_plains() {
        text.text = "You defeated the band of criminals in the, after the battle you found" +
                    "A secret passage which lead outside to what looked to be a plain. " +
                    "You walk for what feels like an enternity until you find a hollow tree" +
                    "Inside you find an old staff and a mana potion you climb the tree " +
                    "and find a rope bridge at the top Press C to continue ";

        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.finalBoss;
        }

    }

    void state_finalBoss() {

    }

    void state_restart() {
        text.text = "You Decided to not take the quest you can either restart at the kingdom " +
                    "Or you can end the game, Press K to restart or X to exit the game ";
        if (Input.GetKeyDown(KeyCode.K)) {
            myState = States.kingdom;
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            Application.Quit();
        }
    }

    void state_advance() {
        text.text = "Thank you brave Hero for deciding to take the quest to return the " +
                    "Kingdoms precious artefact, i will asumme you have made the nessasary " +
                    "Steps to be ready to leave and tell you that there are three starting options " +
                    "Press S to venture to the swamps, F to takle the wild forests " +
                    "Or press U to take on the under ground passages below the kingdom " +
                    "Each will lead to a new challenge and will give you great rewards but at high risks " +
                    "Please be ready great hero to take on the monstors that Barry the great Ogre has left for you! ";

        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.swamp;
        }
        else if (Input.GetKeyDown(KeyCode.F)) {
            myState = States.forest;
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            myState = States.undergroundPassage;
        }
    }
}


