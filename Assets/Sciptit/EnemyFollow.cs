using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject pelaaja;
  

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
        }

    }


    void Update()
    {
        enemy.SetDestination(Player.position);
    }



}


