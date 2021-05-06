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
        if (!firstDialogue) return;
        if (Input.GetKeyDown(KeyCode.E))
         {
             DialogueManager.instance.LoadDialogue(this);
         }
     }
    


  /*  private void Update()
    {



        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
            {
                if (hit.transform.tag == "NPC")
                {
                    Dialogue npcDialogue = hit.transform.GetComponent<Dialogue>();
                    if (npcDialogue != null)
                    {
                        DialogueManager.instance.LoadDialogue(this);
                    }
                }
            }
        }
    }
       
    */

}

