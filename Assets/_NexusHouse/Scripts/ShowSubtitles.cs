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
        await Task.Delay(6 * 1000);
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
        await Task.Delay(5 * 1000);
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
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "He finished them in the late 1900s, so I’m guessing that… at this point, they’re not done yet.";
        await Task.Delay(7 * 1000);
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
        await Task.Delay(5 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void StudyMemorySubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.magenta;
        currentCharacter.text = "LIANA RILEY";
        currentSubtitle.text = "Do you remember our first dance? You stepped on my toes at least five times!";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "But... honestly I wouldn't have it any other way.";
        await Task.Delay(4 * 1000);
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
        await Task.Delay(5 * 1000);
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
        await Task.Delay(19 * 1000);
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
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "It’s gonna take at least 24 hours for this to recharge with enough juice for another jump.";
        await Task.Delay(7 * 1000);
        currentSubtitle.text = "What the hell, might as well start looking now.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "If I’m lucky, the Prism might be here in 1940 too.";
        await Task.Delay(5 * 1000);
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
        await Task.Delay(5 * 1000);
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
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "Promise me that you won’t do anything to make this more dangerous than it already is.";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "Promise me... that you’ll come back to me and the kids.";
        await Task.Delay(4 * 1000);
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
        await Task.Delay(5 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void Toilet2MemorySubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.blue;
        currentCharacter.text = "OTHER SPECTER";
        currentSubtitle.text = "It’s too late for me, and for the next guy. But the one after him, he might have a chance.";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "I hope he makes the right choice… And I hope our sacrifice will mean something.";
        await Task.Delay(6 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void Toilet2MemoryReactSubtitles()
    {
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "Is he talking about me? What… why do I need to make a sacrifice?";
        await Task.Delay(6 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void KeypadSubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "There’s something there, behind those books.";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void WrongPasscode()
    {
        await Task.Delay(1 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "I need to find out what the passcode is. I think I saw some clues downstairs.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "I should go back and try to figure it out.";
        await Task.Delay(3 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void LabSubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "What is this place? Most of these things don’t belong in this era. How is this possible?";
        await Task.Delay(6 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void LabRoomSubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "That’s it. Glowing blue crystal, that has to be the Prism.";
        await Task.Delay(6 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;

    }

    public async void PrismSubtitles()
    {
        await Task.Delay(1 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.blue;
        currentCharacter.text = "OTHER SPECTER";
        currentSubtitle.text = "Simon Riley. I’m leaving this message for you, not even sure if you’ll get it but I have no other option.";
        await Task.Delay(9 * 1000);
        currentSubtitle.text = "I am you. From a different timeline. I went back here to tell you this,";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "and I was the one who changed the year to 1940 before you time-jumped.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "And I know, you don’t trust me. I wouldn’t either.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "But I’m going to ask you to turn your back on the mission.";
        await Task.Delay(3 * 1000);
        currentSubtitle.text = "Giving the Agency that Prism was the worst mistake I’ve ever made.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = " The moment they got their hands on it, everything turned to chaos and… I lost them.";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "Liana, and our kids. I’m doing this, talking to you, so you can do the right thing.";
        await Task.Delay(8 * 1000);
        currentSubtitle.text = "I need you to look for the unfinished prototype of the Chrono-Resonator, somewhere in this house.";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "And you need to destroy it, as well as the one on your wrist.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "This will hopefully create a new timeline, where time-travel never existed.";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "And maybe… maybe there we can keep them safe. Maybe in that timeline, we can be happy.";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "But us… we must make this sacrifice. I trust you.";
        await Task.Delay(7 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void SBPrismReactSubtitles()
    {
        await Task.Delay(2 * 1000);
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "I… If I do this, I’ll never see my family again.";
        await Task.Delay(5 * 1000);
        currentSubtitle.text = "I’ll be stuck here, and they’re going to keep waiting for me to return. Forever. I can’t do that to them!";
        await Task.Delay(9 * 1000);
        currentSubtitle.text = "And for what, for blind hope that life will be better for us in another timeline?";
        await Task.Delay(6 * 1000);
        currentSubtitle.text = "I can’t… it’s too big a sacrifice… ";
        await Task.Delay(4 * 1000);
        currentSubtitle.text = "But… if it’s going to keep them safe…";
        await Task.Delay(7 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }

    public async void FinalChoiceSubtitles()
    {
        currentSubtitle.enabled = true;
        currentCharacter.enabled = true;
        currentCharacter.color = Color.green;
        currentCharacter.text = "SPECTER";
        currentSubtitle.text = "This is it. I need to make my choice. It’s now or never.";
        await Task.Delay(8 * 1000);
        currentSubtitle.enabled = false;
        currentCharacter.enabled = false;
    }
}
