using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent agent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        float nScale = Random.Range(0.25f, 0.85f);
        transform.localScale = Vector3.one * nScale;

        // The smaller the robot, the fastest it is
        agent.speed = 5f * (1-nScale);
        agent.acceleration = 8f * (1-nScale);
        agent.angularSpeed = 200 * (1-nScale);

        agent.height = nScale;
        animator.speed *= (1-nScale);
    }

    
}
