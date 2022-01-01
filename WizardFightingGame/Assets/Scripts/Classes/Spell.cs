using UnityEngine;

public class Spell
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string SpellType { get; set; }
    public GameObject spellObj { get; set; }

    public Spell()
    {
        
    }
}
