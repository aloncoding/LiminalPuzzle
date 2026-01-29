using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Dialogue/New Dialogue Container")]

public class DialogueText : ScriptableObject
{
    public string speakerName;

    [TextArea(5, 10)]
    public string[] paragraphs;
}
