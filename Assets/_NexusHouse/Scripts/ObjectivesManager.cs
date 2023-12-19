using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesManager : MonoBehaviour
{
    public List<GameObject> objectives;
    public int objectiveNumber = 0;

    public void NextObjective()
    {
        objectiveNumber++;
    }
}
