using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class InteractObject : MonoBehaviour
{
    NavMeshAgent agent;
    void Start()
    {
        GameObject protagonist = GameObject.Find("Protagonist");
        agent = protagonist.GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Debug.Log("Clicked");
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            agent.SetDestination(hit.point);
        }
    }

}
