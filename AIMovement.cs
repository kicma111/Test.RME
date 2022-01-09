using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    
    NavMeshAgent agent;
    public Vector2 clickedPos;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            agent.SetDestination(clickedPos);
        }
    }
}
