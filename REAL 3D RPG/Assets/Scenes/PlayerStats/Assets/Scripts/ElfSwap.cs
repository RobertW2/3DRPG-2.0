using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfSwap : MonoBehaviour
{

    public GameObject ElfRaceOn;
    public GameObject OrcRaceOff;
    public GameObject HumanRaceOff;

    public void clicky()
    {
        ElfRaceOn.SetActive(true);

        OrcRaceOff.SetActive(false);
        HumanRaceOff.SetActive(false);

    }
}
