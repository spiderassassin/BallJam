using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject cont;
    public GameObject start;
    public void TriggerDialogue()
    {
    cont.SetActive(true);
    start.SetActive(false);
    
    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }
}
