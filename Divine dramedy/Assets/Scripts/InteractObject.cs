using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class InteractObject : MonoBehaviour
{
    GameObject protagonist;

    [SerializeField] Canvas m_canvas;
    public RectTransform m_parent;
    public Camera m_uiCamera;
    public RectTransform m_group;
    void Start()
    {
        protagonist = GameObject.Find("Protagonist");
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        //ApproachTheObject(mousePos);
        OpenMenu(mousePos);
    }
    void OpenMenu(Vector3 mousePos) 
    {
        

        if (m_canvas.gameObject.activeSelf)
        {
            m_canvas.gameObject.SetActive(false);
        }
        else
        {
            m_canvas.gameObject.SetActive(true);
            
            Vector2 anchoredPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, mousePos, m_canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : m_uiCamera, out anchoredPos);
            m_group.anchoredPosition = anchoredPos;
            
        }

        
    }

    void ApproachTheObject(Vector3 mousePos) 
    {
        protagonist.GetComponent<ClickMovement>().MoveTo(mousePos);
    }






}
