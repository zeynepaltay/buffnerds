using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    enum Rarity
    {
        Commen,
        Uncommen,
        Epic,
        Legendary
    }
    string item;
    Abilitie[] passiveAbilities;
    Abilitie[] specialAbilities;
    public Item()
    {
        
    }
    static void ActiveAbility()
    {

    }
}
