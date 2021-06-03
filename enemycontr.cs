using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemycontr : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public GameObject player;
    float distanceToPlayer;
    public NavMeshAgent nav;
    public Transform player_tr;
    public GameObject enemyHB;
    public GameObject enemy;
    Slider enemyslider_hb; 
    int enemyhp = 100;
    float x;
    float z;
        void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemyslider_hb = enemyHB.GetComponent<Slider>();

        

    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.transform.position, agent.transform.position);
        print(distanceToPlayer);
        nav.SetDestination(player_tr.position);
        if(enemyhp == 0)
        {
           Destroy(enemy); 
        } 
       
        
    }
    void OnMouseDown()
    {
       Destroy(gameObject);
    }
    
}
