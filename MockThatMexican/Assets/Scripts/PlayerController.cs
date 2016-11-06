using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	NavMeshAgent navAgent;

	void Awake()
	{
		navAgent = GetComponent<NavMeshAgent>();
	}


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Move ();
	}

	void Move()
	{        
		if (Input.GetMouseButton (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 100)) {
				navAgent.SetDestination (hit.point);                
			}           
		}
	}
}
