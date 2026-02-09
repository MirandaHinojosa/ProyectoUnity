using System.ComponentModel;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent enemy;
    


    void Start()
    {

    }

    void Update()
    {

        enemy.SetDestination(Player.position);

    }
}