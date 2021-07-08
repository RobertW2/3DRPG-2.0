using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAudio : MonoBehaviour
{
    private void Awake()
    {
        if(FindObjectsOfType<MusicAudio>().Length >= 2)
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(transform.gameObject);
    }
}
