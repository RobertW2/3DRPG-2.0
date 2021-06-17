using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    HealthBarAndLoseHP healthBar;
   public HealthBar Healthbar;
   
    public Transform SpawnPoint;
    public Transform player;
    public GameObject RespawnScreen;

 /*   private void OnTriggerEnter(Collider other)
    {
        player.transform.position = SpawnPoint;
    }
 */

    public void OnTriggerEnter(Collider other)
    {
        //  SceneManager.LoadScene("DeathScene");
        RespawnScreen.SetActive(true);

       
    }

    public void RespawnButton()
    {
        player.transform.position = SpawnPoint.transform.position;
        Physics.SyncTransforms();
        RespawnScreen.SetActive(false);
       
    }

    

}