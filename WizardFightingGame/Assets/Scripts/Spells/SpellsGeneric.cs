using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpellsGeneric : MonoBehaviour
{
    #region Variables
    private bool castConditional;

    #endregion

    #region Properties
    public int Id {get; set;}
    public string Name { get; set; }
    public string damageType { get; set; }
    public int manaCost { get; set; }
    public int castActivationLength { get; set; }
    public int castEnduranceLength { get; set; }
    public int range{ get; set; }
    #endregion

    #region Public Methods
    public bool CastSpell()
    {

        return castConditional;
    }

    #endregion
    
    
    

    
}
