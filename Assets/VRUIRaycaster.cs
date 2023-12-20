using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VRUIRaycaster : MonoBehaviour
{
    public LayerMask layerMask;
    public LineRenderer lineRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit raycastData;
        if(Physics.Raycast(transform.position,transform.forward,out raycastData, 40, layerMask))
        {
            EventSystem.current.SetSelectedGameObject( raycastData.collider.gameObject);
            lineRenderer.SetPosition(1, new Vector3(0, 0, raycastData.distance));
        }
    }
}
