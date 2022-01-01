using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    Queue<Spell> spellQueue = new Queue<Spell>(3);
    
    [SerializeField]
    GameObject spellPrefab;
    Rigidbody playerRB = new Rigidbody();

    
    void Awake()
    {
        playerRB = GetComponent<Rigidbody>();

        foreach (Spell spell in spellQueue)
        {
            spell.spellObj = spellPrefab;

            spellQueue.Enqueue(spell);
        }
    }

    private void FixedUpdate()
    {
        Spell spell = new Spell();

        if(Input.GetKey(KeyCode.Q))
        {
            spell = spellQueue.Dequeue();

            Instantiate(spell.spellObj, new Vector3(0,0,0), Quaternion.identity);
        }
    }
}
