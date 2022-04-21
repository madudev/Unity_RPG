using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{

    [Header("Components")]
    public GameObject dialogueObj; //janela do dialogo
    public Image profileSprite; // sprite do perfil
    public Text speechText; //texto fa fala
    public Text actorNameText;// nome do NPC


    [Header("Settings")]
    public float typingSpeed; // velocidade da fala

    // variaves de controle 
    private bool isShowing; // se a janela está visivel
    private int index; //array das falas
    private string[] sentences;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


    public void NextSentence()
    {

    }

    public void Speech(string[] txt)
    {
        if(!isShowing)
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            isShowing = true;
        }
    }
}
