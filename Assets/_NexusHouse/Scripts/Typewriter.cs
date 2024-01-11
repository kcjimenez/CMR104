using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Threading.Tasks;

public class Typewriter : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public float typingSpeed = 0.3f;

    private string fullText;

    public AudioSource typingSounds;
    public int waitTime;

    private void Start()
    {
        fullText = textMeshPro.text;
        textMeshPro.text = string.Empty;
        //PlayTypingSounds();
        StartCoroutine(TypeText());
    }


    IEnumerator TypeText()
    {
        foreach (char letter in fullText)
        {
            textMeshPro.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private async void PlayTypingSounds()
    {
        typingSounds.Play();
        await Task.Delay(waitTime * 1000);
        typingSounds.enabled= false;
    }
}
