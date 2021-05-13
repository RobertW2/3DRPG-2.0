using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string greeting;
    public string faction;

    public LineOfDialogue1 goodbye;
    
    public LineOfDialogue1[] DialogueOptions;

    public bool firstDialogue;

     private void Update()
     {

        //if (!firstDialogue) return;
        //if (Input.GetKeyDown(KeyCode.E))
        // {
        //     DialogueManager.instance.LoadDialogue(this);
        // }
     }
    



}

