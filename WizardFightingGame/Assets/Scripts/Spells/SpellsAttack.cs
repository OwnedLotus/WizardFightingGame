using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpellsAttack : SpellsGeneric
{
    private int spellDamage;


    #region Attack Spell Properties
    public int damageAmount { get; set; }
    public bool? AOE { get; set; }
    #endregion

    public SpellsAttack(int id, string name, string damageType, int manaCost, int castActivationLength, int castActivationEndurance, int range, int damageAmount, bool? AOE)
    {

    }
    
    
    
    
    
}
