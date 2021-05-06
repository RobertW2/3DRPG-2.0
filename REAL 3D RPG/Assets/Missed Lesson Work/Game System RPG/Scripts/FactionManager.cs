using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Factions
{
    public string factionName;

    float _approval;

    public float approval
    {


        set
        {
            _approval = Mathf.Clamp(value, -1, 1);
        }
        get
        {
            return _approval;


        }
    }
}

public class FactionManager : MonoBehaviour
{

    [SerializeField]
    Dictionary<string, Factions> factions;


    public static FactionManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        factions = new Dictionary<string, Factions>();
        factions.Add("LeaguePlayers", new Factions());
    }

   public float? factionsApproval(string factionName, float value)
    {
        if (factions.ContainsKey(factionName))
        {
            factions[factionName].approval += value;
            return factions[factionName].approval;
        }
        return null;
    }

    public float? getFactionsApproval(string factionName, float value)
    {
        if (factions.ContainsKey(factionName))
        {
            
            return factions[factionName].approval;
        }
        return null;
    }
}
