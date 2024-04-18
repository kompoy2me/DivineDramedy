using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonLook : MonoBehaviour, IPointerClickHandler
{
    GameObject protagonist;
    void Start()
    {
        protagonist = GameObject.Find("Protagonist");
    }

    void Update()
    {

    }

    void ApproachTheObject(Vector3 mousePos)
    {
        protagonist.GetComponent<ClickMovement>().MoveTo(mousePos);
    }

    public void OnPointerClick(PointerEventData eventData) // 3
    {
        print("I was clicked");
        Vector3 mousePos = Input.mousePosition;
        ApproachTheObject(mousePos);
    }
}
