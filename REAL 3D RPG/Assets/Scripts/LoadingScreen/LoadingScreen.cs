using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadingCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadingCoroutine()
    {
        yield return new WaitForSeconds(5);


        SceneManager.LoadScene("PressAnyKey");
    }
}
