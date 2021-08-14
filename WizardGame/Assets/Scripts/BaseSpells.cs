using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpells : MonoBehaviour
{
    #region Variables
    private int ID;
    private string name;
    private string description;
    private string damageType;
    private int manaCost;
    private int castActivationLength;
    private int castEnduraceLength;
    private int range;

    #endregion

    #region Public Properties
    public string Name
    {
        get {  return name;}
        set {  name = value;}
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public string DamageType
    {
        get { return damageType; }
        set { damageType = value; }
    }
    public int ManaCost
    {
        get { return manaCost; }
        set { manaCost = value; }
    }
    public int CastActivationLength
    {
        get { return castActivationLength; }
        set { castActivationLength = value; }
    }
    public int CastEnduranceLength
    {
        get { return castEnduraceLength; }
        set { castEnduraceLength = value; }
    }
    public int Range
    {
        get { return range; }
        set { range = value; }
    }
    #endregion

    #region Methods
    public virtual bool CastSpell()
    {
        return true;
    }
    #endregion

}
