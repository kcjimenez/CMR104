using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Threading.Tasks;
using UnityEngine;

public class ShowSubtitles : MonoBehaviour
{
    [SerializeField] TMP_Text currentSubtitle;

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void ActivateSubtitles()
    {
        currentSubtitle.enabled = true;
    }*/

    public async void InterfaceOneSubtitles()
    {
        currentSubtitle.enabled = true;
        currentSubtitle.text = "Target destination reached. Please be mindful of any interactions with the past,";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "for your safety, and for the safety of the timeline.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
    }
}
