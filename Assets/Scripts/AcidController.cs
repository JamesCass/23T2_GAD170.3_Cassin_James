using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcidController : MonoBehaviour
{
    //Checks if the player has entered the acid collider and if so reloads the scene to 'respawn' the Player Character.
    private void OnTriggerEnter(Collider col)
    {
        //Checks to make sure the GameObject that collides with the acid has the tag "Player".
        if (col.CompareTag("Player"))
        {
            //... reloads the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
