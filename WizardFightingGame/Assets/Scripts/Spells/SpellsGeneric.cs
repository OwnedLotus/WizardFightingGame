using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsGeneric : MonoBehaviour
{
    bool castConditional;

    private int Id {get; set;}
    private string Name { get; set; }
    private string damageType { get; set; }
    private int manaCost { get; set; }

    public bool CastSpell()
    {

        return castConditional;
    }
    
    
    

    
}
