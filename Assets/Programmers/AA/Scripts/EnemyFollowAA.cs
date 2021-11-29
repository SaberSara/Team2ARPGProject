using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowAA : MonoBehaviour
{
    [SerializeField] private VectorThreeValue enemyPosition;
    public NavMeshAgent enemy;

    public Transform Player;

    private void Awake()
    {
        enemyPosition.Vector3Value = transform.position;
    }

    void Update()
    {
        enemy.SetDestination(Player.position);
        enemyPosition.Vector3Value = transform.position;
    }
}
