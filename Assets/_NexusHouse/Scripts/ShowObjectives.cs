using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public class ShowObjectives : MonoBehaviour
{
    [SerializeField] TMP_Text currentObjective;
    [SerializeField] TMP_Text pressX;
    public int collectedClues;
    bool isCCObjectiveActive = true;

    // Start is called before the first frame update
    void Start()
    {
        //currentObjective = collectCluesObjective;

    }

    // Update is called once per frame
    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            pressX.enabled = false;
            Debug.Log("show objective");
            currentObjective.enabled = true;

            if(isCCObjectiveActive)
            {
                CollectCluesObjective();
            }

            await Task.Delay(5 * 1000);
            currentObjective.enabled = false;
        }

        if (collectedClues >= 3)
        {
            var obj = GameObject.FindGameObjectWithTag("Voice2Trigger");
            Debug.Log("trigger found");
            obj.GetComponent<BoxCollider>().enabled = true;
            await Task.Delay(6 * 1000);
            isCCObjectiveActive = false;
        }
    }

    public void AddClues()
    {
        collectedClues++;
    }

    public async void CollectCluesObjective()
    {
        if (collectedClues == 0)
        {
            currentObjective.text = "Collect Clues (0/3)";
        }

        else if (collectedClues > 0)
        {
            currentObjective.text = "Collect Clues (" + collectedClues + "/3)";
        }
    }

    public void CheckMissionBrief()
    {
        currentObjective.text = "Press on the Chrono-Resonator to check the Mission Brief";
        currentObjective.enabled = false;
    }

    public void ExploreObjective()
    {
        currentObjective.text = "Keep Exploring";
        currentObjective.enabled = false;
    }

    public void UpstairsObjective()
    {
        currentObjective.text = "Go Upstairs";
        currentObjective.enabled = false;
    }
}
