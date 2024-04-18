using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInteractWindow : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                //Debug.Log(hit.collider.gameObject.name);
                float dist = Vector3.Distance(hit.collider.gameObject.transform.position, transform.position);
                Debug.Log("dist to "+ hit.collider.gameObject.name + " " + dist);
            }
        }
    }
}
