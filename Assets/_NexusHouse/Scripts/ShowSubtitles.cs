using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Threading.Tasks;
using UnityEngine;

public class ShowSubtitles : MonoBehaviour
{
    [SerializeField] TMP_Text currentSubtitle;
    [SerializeField] TMP_Text currentCharacter;

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
        currentCharacter.enabled = true;
        currentCharacter.color = Color.yellow;
        currentCharacter.text = "INTERFACE";
        currentSubtitle.text = "Target destination reached. Please be mindful of any interactions with the past,";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "for your safety, and for the safety of the timeline.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void SBVoice1Subtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "Hmm… This looks like the right place but…";
        await Task.Delay(2 * 1000);
        currentSubtitle.text = "It looks different from what they showed me in the briefing.";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "Looks… older. I should try to look for something to confirm where I am.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void Clue1Subtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "1940… No, no. I’m supposed to be in 1990, I’m positive that’s what I punched into my Chrono-Res.";
        await Task.Delay(7 * 1000);
        currentSubtitle.text = "I don’t make mistakes like this… What’s going on?";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void Clue2Subtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "Dr. Alistair Gray. That’s him, that’s the guy that made the Chrono-Resonators.";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "He finished them in the late 1900s, so I’m guessing that… at this point, they’re not done yet.";
        await Task.Delay(6 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void Memory1Subtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.blue;
        currentCharacter.text = "OTHER SPECTER";
        currentSubtitle.text = "This has to work. I NEED this to work. There’s no other way.";
        await Task.Delay(5 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

}
