using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public Transform Player;


    void Update()
    {
        Enemy.SetDestination(Player.position);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            SceneManager.LoadScene(1);
        }
        if (col.gameObject.name == "Vihollinen")
        {
            SceneManager.LoadScene(1);

        }
    }




}


