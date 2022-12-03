using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCharacterClass
{
    public string Nickname;
    public string Title;
    //races : 0 = african , 1 = asian, 2 = caucasian
    public int race;
    //races : 0 = muscle , 1 = ninja , 2 = Gunslinger , 3 = Marksman
    public int classType;
    //races : 0 = farmer , 1 = miner , 2 = chemist , 3 = druglord , 4 = armslord , 5 = jeweler , 6 = tailor , 7 = mechanic , 8 = medic , 9 =
    public int profession;
    public int level;
    public int currentexp;
    public int health;
    public int stamina;
    public int item_head_slot;
    public int item_neck_slot;
    public int item_chest_slot;
    public int item_legs_slot;
    public int item_foots_slot;
    public int item_leftbracer_slot;
    public int item_rightbracer_slot;
    public int item_gloves_slot;

    public InventoryClass Inventory;
}
