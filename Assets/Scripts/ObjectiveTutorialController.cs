using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveTutorialController : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;

    //Ensures the text box is disabled at the start of gameplay.
    private void Start()
    {
        //... text is set to false.
        textBox.enabled = false;
    }

    //Enables text when the Player Character enters the trigger zone.
    private void OnTriggerEnter(Collider other)
    {
        //... text is now enabled.
        textBox.enabled = true;
    }

    //Ensures the text is disabled when the player leaves the trigger zone.
    private void OnTriggerExit(Collider other)
    {
        //... text is now disabled.
        textBox.enabled = false;
    }
}
