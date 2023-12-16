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

    public async void ToiletMemoryReactSubtitles()
    {
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "What? That was my voice… but it wasn’t me.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void StudyMemorySubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.magenta;
        currentCharacter.text = "LIANA RILEY";
        currentSubtitle.text = "Remember our first dance? You stepped on my toes at least five times!";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "But I wouldn't have it any other way.";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void StudyMemoryReactSubtitles()
    {
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "Liana? What… why am I hearing this?";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void RadioSubtitles()
    {
        await Task.Delay(9 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.blue;
        currentCharacter.text = "OTHER SPECTER";
        currentSubtitle.text = "Simon–’ts me—-you—-destroy—ch–res—-stop—time travel—-invente—----Trust me.";
        await Task.Delay(9 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void RadioReactSubtitles()
    {
        await Task.Delay(18 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "There! That was my voice again.";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void SBVoice2Subtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "I should check the briefing again.";
        await Task.Delay(2 * 1000);
        currentSubtitle.text = "Maybe there was some sort of… last-minute change?";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }
    
    public async void MissionBriefSubtitles()
    {
        await Task.Delay(6 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.yellow;
        currentCharacter.text = "INTERFACE";
        currentSubtitle.text = "Agent Specter. You have been assigned to a solo mission, Operation: Nexus House.";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "This refers to Dr. Alistair Gray’s residence, where you will need to go.";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "You must travel to the year 1990 and retrieve the artifact known as the Prism.";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "It has been described as a small, blue crystal with a slight glow,";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "and we have no other information about its’ whereabouts,";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "aside from the fact that it’s inside the house.";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "Know that this object is of absolute importance to us,";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "and could completely change the way time-travel works.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "We’re sending you because you’re our best, and we know you won’t let us down…";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "Godspeed.";
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
        await Task.Delay(5 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "Nothing new there. And now my Chrono-Res is all drained…";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "It’s gonna take at least 24 hours for this to recharge with enough juice for another jump.";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "What the hell, might as well start looking now.";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "If I’m lucky, the Prism might be here in 1940 too.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void WallMovingReact()
    {
        await Task.Delay(7 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "What was that?";
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void SBVoice3Subtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "A hidden staircase? I might find what I’m looking for up there.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void StairsMemorySubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.magenta;
        currentCharacter.text = "LIANA RILEY";
        currentSubtitle.text = "Listen to me. You do your mission and you come right back here.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "Promise me that you won’t do anything to make this more dangerous than it already is.";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "Promise that you’ll come back to me and the kids.";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void StairsMemoryReactSubtitles()
    {
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "My wife said that to me before I left for my mission.";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "I need to keep my promise and get this done as quickly and safely as I can.";
        await Task.Delay(4 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }
}
