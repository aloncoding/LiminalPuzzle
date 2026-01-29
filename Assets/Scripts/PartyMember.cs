using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartyMember : NPC, ITalkable
{  
    [SerializeField] private DialogueText dialogueText;
    public override void Interact()
    {
        Talk(dialogueText);
    }

    public void Talk(DialogueText dialogueText)
    {
        //start conversation
        
    }
}
