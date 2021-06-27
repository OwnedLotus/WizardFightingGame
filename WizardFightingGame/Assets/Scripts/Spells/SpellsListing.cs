using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpellsListing : MonoBehaviour
{

    #region Variables
    public int numberOfSpells = 1;
    #endregion

    ///<summary>
    /// Global Spells initialization
    ///</summary>
    


    private void Start() 
    {
        SpellsAttack[] attackSpells = new SpellsAttack[numberOfSpells];
        SpellsStatus[] statusSpells = new SpellsStatus[numberOfSpells];
        
    }
    
    

}
