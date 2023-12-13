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
        currentSubtitle.text = "INTERFAACE: Target destination reached. Please be mindful of any interactions with the past,";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "INTERFACE: for your safety, and for the safety of the timeline.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
    }

    public async void SBVoice1Subtitles()
    {
        currentSubtitle.enabled = true;
        currentSubtitle.text = "SPECTER: Hmm… This looks like the right place but…";
        await Task.Delay(2 * 1000);
        currentSubtitle.text = "SPECTER: It looks different from what they showed me in the briefing.";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "SPECTER: Looks… older. I should try to look for something to confirm where I am.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
    }
}
