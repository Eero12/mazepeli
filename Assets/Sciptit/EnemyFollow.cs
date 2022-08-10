using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject gameObject;

    void Start()
    {

    }

    void Update()
    {
        enemy.SetDestination(Player.position);
    }

  
    void OnCollisionEnter(Collision collision)
    {
 
        if (collision.gameObject.tag == "Vihollinen")
        {
            SceneManager.LoadScene(0);
        }

    }
}
