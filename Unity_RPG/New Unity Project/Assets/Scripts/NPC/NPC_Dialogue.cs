using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{

    public float dialogueRange;
    public LayerMask playerlayer;
    public DialogueSettings dialogue;


    bool playerHit;

    private void Start()
    {
        GetNPCInfo();
    }

    private List<string> sentences = new List<string>();

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerHit)
        {
            DialogueControl.instance.Speech(sentences.ToArray());
        }
    }

    void GetNPCInfo()
    {
        for(int i = 0; i < dialogue.dialogues.Count; i++)
        {
           switch(DialogueControl.instance.language)
           {
               case DialogueControl.idiom.pt:
                    sentences.Add(dialogue.dialogues[i].sentence.portuguese);
                    break;

                case DialogueControl.idiom.eng:
                    sentences.Add(dialogue.dialogues[i].sentence.english);
                    break;

                case DialogueControl.idiom.spa:
                    sentences.Add(dialogue.dialogues[i].sentence.spanish);
                    break;
           }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerlayer);
        if(hit != null)
        {
            playerHit = true;
        }
        else
        {
            playerHit = false;

        }
    }

    private void OnDrawGizmosSelectde()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }

}
