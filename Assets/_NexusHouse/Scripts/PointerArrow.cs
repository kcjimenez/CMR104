using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.XR;
using UnityEngine;
using UnityEngine.Events;

public class PointerArrow : MonoBehaviour
{
    //[SerializeField] List<GameObject> objectives;
    int objectiveNumber;
    //MeshRenderer meshRenderer;
    //bool arrowActive;
    //List<ObjectivesManager> objectivesList;
    GameObject objectivesManager;
    ObjectivesManager objManagerScript;
    //public UnityEvent onArrowActive;
    List<GameObject> objList;

    public void onArrowEnable()
    {
        Debug.Log("arrow onenable called");
        objectivesManager = GameObject.FindGameObjectWithTag("ObjectivesManager");
        objManagerScript = objectivesManager.GetComponent<ObjectivesManager>();
        objList = objManagerScript.objectives;
        //objectiveNumber = objManagerScript.objectiveNumber;
    }

    // Update is called once per frame
    void Update()
    {
        objectiveNumber = objManagerScript.objectiveNumber;
        this.transform.LookAt(objList[objectiveNumber].transform.position);

        /*if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            meshRenderer.enabled = true;
            await Task.Delay(5 * 1000);
            meshRenderer.enabled = false;
        }*/
    }
}
