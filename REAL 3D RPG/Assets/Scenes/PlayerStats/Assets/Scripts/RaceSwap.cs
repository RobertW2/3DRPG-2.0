using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceSwap : MonoBehaviour
{
    public GameObject newRaceOn;
    public GameObject oldRaceOff;

    public void clicky()
    {
        newRaceOn.SetActive(true);

       // oldRaceOff.SetActive(false);

        
    }
}
