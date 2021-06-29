using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
