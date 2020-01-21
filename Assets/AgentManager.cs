using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{

    public Transform playerController;        
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject a in agents)
        {
            a.GetComponent<AIControl>().agent.SetDestination(playerController.position);
        }
    }

}
