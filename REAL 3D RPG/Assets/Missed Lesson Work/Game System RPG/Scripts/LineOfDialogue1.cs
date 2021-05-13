using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class LineOfDialogue1
{
    [TextArea(2, 6)]
    public string topic, response;
    public int minIntel;

    public float minApproval = -1f;
    public float changeApproval = 0f;

    public Dialogue nextDialogue;

    [System.NonSerialized]
    public int buttonID;

}
