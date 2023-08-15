using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TreasureController : MonoBehaviour
{
    [SerializeField] private TextMeshPro infoTextBox;
    [SerializeField] private TextMeshPro winTextBox;
    [SerializeField] private bool isPlayerCharacterNextToTreasure = false;
    [SerializeField] private GameObject treasure;

    //At the start ensures the text boxes are disabled as well as the check to make sure the player is close enough to the treasure.
    void Start()
    {
        //... all text and vicinity check is set to false; 
        infoTextBox.enabled = false;
        winTextBox.enabled = false;
        isPlayerCharacterNextToTreasure = false;
    }
    //When the Player Character enters the trigger zone enables the text and the check to allow the player to press the button.
    private void OnTriggerEnter(Collider other)
    {
        //... text is enables and so is Player Character vicinity check
        infoTextBox.enabled = true;
        isPlayerCharacterNextToTreasure = true;
    }
    //Ensures that when the Player Character leaves the trigger zone the text and vicinity check are disabled.
    private void OnTriggerExit(Collider other)
    {
        //... text and vicinity check are disabled.
        infoTextBox.enabled = false;
        isPlayerCharacterNextToTreasure = false;
    }

    //Checks if the player is pressing "E" and in the vicinty of the treasure and if so remove the treasure GameObject and enable the win text.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToTreasure)
        {
            //... destroys the treasure GameObject and enables the win text box.
            Destroy(treasure);
            winTextBox.enabled = true;
        }
        //Checks if the player presses "Escape" during gameplay and if so quits the game.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
