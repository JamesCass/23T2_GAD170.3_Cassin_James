using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesController : MonoBehaviour
{
    //Checks if player touches spikes and if so 'respawns' the player character.
    private void OnTriggerEnter(Collider col)
    {
        //Checks for the GameObject with the tag 'Player'
        if (col.CompareTag("Player"))
        {
            //... reloads scene after player character collides with spikes.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
