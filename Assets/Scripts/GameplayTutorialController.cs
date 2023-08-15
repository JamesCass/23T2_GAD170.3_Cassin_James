using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayTutorialController : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;

    //Ensures text is disabled at game start.
    private void Start()
    {
        //... text is disabled.
        textBox.enabled = false;
    }

    //Checks if Player Character is in trigger zone to enable text.
    private void OnTriggerEnter(Collider other)
    {
        //... text is set to enabled.
        textBox.enabled = true;
    }

    //When player leaves the trigger zone ensures the text is disabled.
    private void OnTriggerExit(Collider other)
    {
        //... text is disabled.
        textBox.enabled = false;
    }
}
