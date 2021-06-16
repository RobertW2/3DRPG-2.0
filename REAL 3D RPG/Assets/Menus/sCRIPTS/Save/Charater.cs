using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Serialization
{
    // This is how C# and .NET know that they can actually turn this into JSON or
    // binary data for saving in files
    [System.Serializable] 
    public class Charater 
    {

        // Cannot serialize public
        public string name;
        public int strength;
        public int wisdom;
        public int charisma;
        public int intelligence;
        public int constitution;
        public int dexterity;
        public int level;

        public Charater(string _name, int _strength, int _wisdom, int _intelligence, int _charisma, 
            int _constitution, int _dexterity, int _level)
        {
            name = _name;
            strength = _strength;
            wisdom = _wisdom;
            charisma = _charisma;
            intelligence = _intelligence;
            constitution = _constitution;
            dexterity = _dexterity;
            level = _level;
        }
    }
}
