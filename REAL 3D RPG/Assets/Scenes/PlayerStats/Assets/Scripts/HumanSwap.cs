using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSwap : MonoBehaviour
{
    public GameObject HumanRaceOn;
    public GameObject OrcRaceOff;
    public GameObject ElfRaceOff;

    public void clicky()
    {
        HumanRaceOn.SetActive(true);
        OrcRaceOff.SetActive(false);
        ElfRaceOff.SetActive(false);    
      

    }
}
