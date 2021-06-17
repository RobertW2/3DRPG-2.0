using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceScriot : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject humanRenderMesh;
    public Renderer ren;
    public Material[] mat;

    void Start()
    {
        ren = humanRenderMesh.GetComponent<Renderer>();
        mat = ren.materials;
        mat[0].color = Color.red;
        mat[1].color = Color.blue;
        mat[8].color = Color.black;
    }


    // Could also disable and exable gameObjects with differet outfits.
    // eg. 3 different Warriors with different colours.


}
