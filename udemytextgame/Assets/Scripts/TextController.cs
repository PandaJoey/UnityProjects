using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {
        kingdom_0, kingdom_1, kingdom_2, kingdom_3, swamp, forest, undergroundPassage,
        temple, dungeon, lake, plains_0, mountains, finalBoss,
        restart_0, restart_1, advance, swampBoss, forestBoss, templeBoss
                          , dungeonBoss, returnToKingdom, plains_1
    };
    private States myState;


    // Use this for initialization
    void Start() {
        myState = States.kingdom_0;
    }

    // Update is called once per frame
    void Update() {
        print(myState);
        if (myState == States.kingdom_0) {
            kingdom_0();
        }
        else if (myState == States.kingdom_1) {
            kingdom_1();
        }
        else if (myState == States.kingdom_2) {
            kingdom_2();
        }
        else if (myState == States.kingdom_3) {
            kingdom_3();
        }
        else if (myState == States.swamp) {
            swamp();
        }
        else if (myState == States.forest) {
            forest();
        }
        else if (myState == States.undergroundPassage) {
            undergroundPassage();
        }
        else if (myState == States.temple) {
            temple();
        }
        else if (myState == States.dungeon) {
            dungeon();
        }
        else if (myState == States.lake) {
            lake();
        }
        else if (myState == States.plains_1) {
            plains_1();
        }
        else if (myState == States.plains_0) {
            plains_0();
        }
        else if (myState == States.mountains) {
            mountains();
        }
        else if (myState == States.finalBoss) {
            finalBoss();
        }
        else if (myState == States.restart_0) {
            restart_0();
        }
        else if (myState == States.restart_1) {
            restart_1();
        }
        else if (myState == States.advance) {
            advance();
        }
        else if (myState == States.swampBoss) {
            swamp_boss();
        }
        else if (myState == States.templeBoss) {
            temple_boss();
        }
        else if (myState == States.forestBoss) {
            forest_boss();
        }
        else if (myState == States.dungeonBoss) {
            dungeon_boss();
        }
        else if (myState == States.returnToKingdom) {
            return_to_kingdom();
        }

    }
    void kingdom_0() {
        text.text = "You are the kingdoms hero and have just been summoned by your king " +
                    "he tells you that one of the kingdoms rarest artefacts has been stolen " +
                    "the villain is Barrinov the Great Ogre, The most feared villain in the land " +
                    "as the kingdoms hero, he asked you to go on a quest to find Barry " +
                    "Will you accept the kings Quest? \n\n" +
                    "Press N if you do not wish to take the quest \n\n" +
                    "Press Y if you will take the Kings quest ";
        if (Input.GetKeyDown(KeyCode.N)) {
            myState = States.restart_0;
        }
        else if (Input.GetKeyDown(KeyCode.Y)) {
            myState = States.advance;
        }
    }
    void kingdom_1() {
        text.text = "You decided to retreat from the swap and are now back in the kingdom," +
                    "the swamp is no longer an option. You must now decide if you want to " +
                    "Wander through the wild forests, delve into the underground passage or " +
                    "Abandon the quest. \n\n" +
                    "For the forest press F, the underground passage U or A to abandon the quest ";

        if (Input.GetKeyDown(KeyCode.F)) {
            myState = States.forest;
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            myState = States.undergroundPassage;
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.restart_1;
        }


    }
    void kingdom_2() {
        text.text = "You decided to retreat from the forest and are now back in the kingdom, " +
                    "the forest is no longer an option. You must now decide if you want to " +
                    "wade through the swamps, delve into the underground passage or " +
                    "abandon the quest. \n\n" +
                    "For the swamps press S, the underground passage U or A to abandon the quest ";

        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.forest;
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            myState = States.undergroundPassage;
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.restart_1;
        }


    }
    void kingdom_3() {
        text.text = "You decided to retreat from the underground passage and are now back in the kingdom, " +
                    "the underground is no longer an option. You must now decide if you want to " +
                    "wander through the wild forests, Wade through the swamps " +
                    "abandon the quest. \n\n" +
                    "For the forest press F, the swamps S or A to abandon the quest ";

        if (Input.GetKeyDown(KeyCode.F)) {
            myState = States.forest;
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.undergroundPassage;
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.restart_1;
        }


    }
    void restart_0() {
        text.text = "You Decided to not take the quest you can either restart at the kingdom " +
                    "or you can end the game. \n\n" +
                    "Press K to restart or X to exit the game ";
        if (Input.GetKeyDown(KeyCode.K)) {
            myState = States.kingdom_0;
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            Application.Quit();
        }
    }

    void restart_1() {
        text.text = "You retreated from the fight and have failed the quest the kingdom " +
                    "had set out for you. You have two options Exiles or restart the quest\n\n" +
                    "Press R to restart or E for exile ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.kingdom_0;
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            Application.Quit();
        }
    }

    void advance() {
        text.text = "Thank you brave Hero for taking the quest to return the " +
                    "kingdoms precious artefact, I will assume you have made the necessary " +
                    "preparations to be ready to leave and tell you that there are three areas to start your search. \n" +
                    "Each will lead to a new challenge and will give you great rewards but at high risks. " +
                    "Please be ready great hero to take on the monsters that Barrinov the great ogre has left for you!\n\n" +
                    "Press S to venture to the swamps, F to tackle the wild forests " +
                    "or press U to take on the underground passages below the kingdom. ";


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

    void swamp() {
        text.text = "You have decided to venture to the swamps, on arrival " +
                    "you are met with the foulest stench imaginable. " +
                    "The only way through is the wade into the swamp, while wading " +
                    "you find a battered chest under a crevice, to your amazement " +
                    "you find the Great Sword of Chancharu. Legends say this sword was " +
                    "Lost at the battle of Harrallmemel, this sword will most certainly help you on your quest. " +
                    "As you carry on wading you notice " +
                    "the smell of the swamp become more overbearing than before. \n\n" +
                    "Press K to head back to the kingdom or A to advance onward. ";
        if (Input.GetKeyDown(KeyCode.K)) {
            myState = States.kingdom_1;
            // figure out how to select items
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.swampBoss;
            // figure out how to select items
        }
    }
    void swamp_boss() {
        // need to figure out a transition for this text
        text.text = "Advancing on further into the swap, suddenly a huge blob appears " +
                    "you have never seen anything so gigantic, its green in colour and slightly " +
                    "translucent and the smell is overbearing. " +
                    "It starts rolling towards you What will you do? \n\n" +
                    "Press A to attack or R to run. ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.restart_1;
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.temple;
        }
    }

    void temple() {
        text.text = "After a long-fought battle with the giant blob you managed to come out the victor " +
                    "after finding out it was weak to ice magic the fight ended up in your favour. " +
                    "You carry on your path and come to the end of the swap, what stands before you is " +
                    "the most beautiful temple you have even seen. " +
                    "It is blindingly white and as tall as the eye can see, " +
                    "you venture inside and start to look \n" +
                    "Through the rooms inside the temple. It feels strange how quiet it is as you walk. " +
                    "in the centre of the room there is an alter which looks to be housing an item, you take it " +
                    "it’s some sort of talisman. Suddenly the whole building " +
                    "starts to shake, you look up and see a huge gargoyle it starts flying at you \n\n" +
                    "Press A to attack or R to run. ";

        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.templeBoss;
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.restart_1;
        }


    }
    void temple_boss() {
        text.text = "You engage in battle with the gargoyle, you try to use magic but," +
                    "soon find out that the gargoyle has great resistance to it. The battle " +
                    "continues you are dodging and parrying its attacks, you stab the gargoyle but it " +
                    "has no effect. You look to your pocket and notice that the talisman is glowing, " +
                    "you take it from your pocket and aim it at the gargoyles face. It starts to screech " +
                    "and you notice it is turning back to stone. You smash some of the windows near the gargoyle, " +
                    "the sunlight fully turns it to stone. The battle was long but you cannot stop. " +
                    "There are two exits from the temple, one leads to the right and the other to left. " +
                    "Which will you take? \n\n" +
                    "Press R to take the right path and L to take the left path. ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.lake;
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.plains_0;
        }

        //this is where in need to start a fighting state.

    }

    void forest() {
        text.text = "So you chose to go into the forest, it seems darker than dark under the thick while growth. " +
                    "As you walk through the trees you hear noises you have never heard before " +
                    "Suddenly you are attacked, a tree has come to life and has started thrashing around trying to hit you \n\n" +
                    "What will you do? Press A to attack or R to run. ";
        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.forestBoss;
            // figure out how to start a battle sequence
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.kingdom_2;
        }

    }

    void forest_boss() {
        text.text = "You decided to stay and fight the tree valiantly. " +
                    "You block its thrashes with your shield, running and dodging as much as possible " +
                    "while try and find a weakness, suddenly you see an opening and shoot your fire magic " +
                    "into the trees centre. This seems super effective, the battle continues, blocking, " +
                    "and firing until the tree boss is defeated. You notice two ways out of the forest. \n\n" +
                    "Press T to move forward to the temple or D to move to the dungeons. ";
        if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.temple;

        }
        if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.dungeon;
        }

    }

    void undergroundPassage() {
        text.text = "The Underground passage, leading from the castle to the outside " +
                    "What will await you hero as you travel through the underground " +
                    "As you walk throw the tunnels you see a passage glinting in the distance " +
                    "It seems you have stumbled upon the treasury, you take what you need " +
                    "to help you on your quest then carry on moving through the underground passage. \n\n" +
                    "To carry on press D and to go back to the kingdom press K. ";
        if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.dungeon;
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            myState = States.kingdom_3;
        }
    }

    void dungeon() {
        text.text = "You arrive at the dungeon, for some reason there are no guards and " +
                    "all the cells are open, you assume the prison is just deserted. " +
                    "As you make your way through the dungeon, you see a light at the end of " +
                    "the Passageway what will you do? \n\n" +
                    "press T to turn back or P to procced down the passageway.  ";
        if (Input.GetKeyDown(KeyCode.P)) {
            myState = States.dungeonBoss;
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.restart_1;
        }

    }

    void dungeon_boss() {
        text.text = "You carry on down the passage way when you start to hear voices " +
                    "You get close to listen, you hear men talking about killing the guards " +
                    "You try to sneak in to get a better look but one of the bandits sees you, " +
                    "you run back down the passageway looking you quickly set a magical trap in one of the rooms. " +
                    "You take out 3 of the bandits, just the big boss left, you fight him in hand to hand combat " +
                    "he slashes your arm making your shield unusable, the battle continues its tough but you stab him in the " +
                    "heart for your victory. After the battle, you take some time to heal your wounds then notice 2 pathways out. \n\n" +
                    "Press R to head right and L to head left. ";
        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.plains_0;
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.mountains;
        }
    }

    void lake() {
        text.text = "After vanquishing the great gargoyle you chose to take the left path. " +
                    "After some time walking you see water on the horizon, it appears you have come to " +
                    "a great lake. \n" +
                    "You find a boat and start to row across the lake, you notice a small opening. " +
                    "In the cliff edge and row towards it. Once inside you find a chest, " +
                    "You open the chest and find some magical potions that can be used to " +
                    "replenish your health and magic reserves.\n\n" +
                    "You continue on until you arrive at a huge castle Press C to continue ";
        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.finalBoss;
        }
    }


    void plains_0() {
        text.text = "You defeated the band of criminals in the, after the battle you found " +
                    "A secret passage which lead outside to what looks to be a great plain. " +
                    "You walk for what feels like an eternity until you find a hollow tree " +
                    "You use this time to rest up build a fire and replenish your vitality. " +
                    "The next morning you come to a chasm and find a rope bridge, on the other " +
                    "side you see a huge black castle. \n\n" +
                    "Press C to continue ";

        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.finalBoss;
        }

    }
    void plains_1() {
        text.text = "You defeated the great gargoyle in the, after the battle you found " +
                    "A secret passage which lead outside to what looked to be a plain. " +
                    "You walk for what feels like an eternity until you find a hollow tree " +
                    "You use this time to rest up build a fire and replenish your vitality. " +
                    "The next morning you come to a chasm and find a rope bridge, on the other " +
                    "side you see a huge black castle. \n\n" +
                    "Press C to continue ";

        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.finalBoss;
        }

    }

    void mountains() {
        text.text = "After beating the group of bandits you decided to take the right path out of the dungeons " +
                    "you arrive at a giant mountain. You begin your trek up the mountain, it starts to get dark " +
                    "you find a small cave and start a fire ready to bed down for the night. " +
                    "In the morning, you carry on your trek up the mountain when you see something glinting in the distance. " +
                    "You approach it, it’s a steal platform with a button on it, you press the button " +
                    "some short of glider appears you can use this to fly down the mountain faster. " +
                    "At the bottom of the mountain there is a huge black castle.\n\n" +
                    "Press C to continue. ";
        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.finalBoss;
        }
    }

    void finalBoss() {
        text.text = "After arriving at the castle you see that the drawbridge is down " +
                    "and the gate is open, this is very strange, you get the sense that someone " +
                    "is watching you and willing you to enter. " +
                    "You enter the castle and start making you way up the stairs heading for the throne room. " +
                    "Entering the throne room, you see someone sitting in the throne, its Barinov the ogre, he says " +
                    "he’s been waiting for you to arrive and wants to fight you for the kingdoms ancient relics. " +
                    "This is what you have been traveling for and the battle gets underway, both of you flailing your swords " +
                    "and shoot magic at one another. You take a hit to the arm from Barinov’s fire spell, your arm is now " +
                    "useless. However, Barinov has taken a stab to the leg and can no longer stand. This is it, you go in for " +
                    "the final blow and cut off his head. You are victorious and have taken back the stolen artefacts. \n\n" +
                    "Press K to return to the kingdom for a hero’s welcome. ";
        if (Input.GetKeyDown(KeyCode.K)) {
            myState = States.returnToKingdom;
        }

    }
    void return_to_kingdom() {
        text.text = "After returning from your quest to a hero’s welcome the King wishes you well " +
                    "and asks you to take a well-deserved rest. \n\n" +
                    "Until the next Quest warriors, if you would like to restart the game \n" +
                    "press R or to quit press Q ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.kingdom_0;
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            Application.Quit();
        }
    }


}


