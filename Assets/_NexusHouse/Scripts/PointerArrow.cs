using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.XR;
using UnityEngine;

public class PointerArrow : MonoBehaviour
{
    [SerializeField] List<GameObject> objectives;
    public int objectiveNumber = 0;
    public MeshRenderer meshRenderer;
    //bool arrowActive;

    // Update is called once per frame
    async void Update()
    {
        this.transform.LookAt(objectives[objectiveNumber].transform.position);

        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            meshRenderer.enabled = true;
            await Task.Delay(5 * 1000);
            meshRenderer.enabled = false;
        }
    }

    public void NextObjective()
    {
        objectiveNumber++;
    }
}
