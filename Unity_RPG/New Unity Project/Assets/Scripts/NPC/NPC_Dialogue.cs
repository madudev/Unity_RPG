using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{

    public float dialogueRange;
    public LayerMask playerlayer;


    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("Aqui");
        }
        else
        {

        }
    }

    private void OnDrawGizmosSelectde()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }

}
