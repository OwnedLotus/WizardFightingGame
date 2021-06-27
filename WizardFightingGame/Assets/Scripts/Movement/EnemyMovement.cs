using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent navMeshAgent = new NavMeshAgent();
    Rigidbody enemyRB = new Rigidbody();


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        enemyRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnPatrol()
    {

    }

    void OnChase()
    {

    }

    void OnAttack()
    {

    }
}
