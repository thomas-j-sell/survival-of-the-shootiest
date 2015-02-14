using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	Transform player;
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	NavMeshAgent nav;


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Playa").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
		Debug.Log (player);
		Debug.Log (player.position);
		Debug.Log (nav);
	}


	void Update ()
	{
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{
		nav.SetDestination (player.position);
		Debug.Log ("Target postition: " + player.position);
		//}
		//else
		//{
		//    nav.enabled = false;
		//}
	}
}
