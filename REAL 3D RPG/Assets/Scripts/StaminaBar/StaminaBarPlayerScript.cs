using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBarPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Sprint"))
            StaminaBar.instance.UseStamina(1);
    }
}
