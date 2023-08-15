using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WarningTutorialController: MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;


    //Ensures the text box starts disabled.
    private void Start()
    {
        //... text is set to false.
        textBox.enabled = false;
    }
 
    //Checks for if the player has entered a trigger in order to enable a text box.
    private void OnTriggerEnter(Collider other)
    {
        //... textbox is enabled.
        textBox.enabled = true;
    }

    //Ensures once the player leaves the area with the text box it is disabled.
    private void OnTriggerExit(Collider other)
    {
        //... text box is disabled.
        textBox.enabled = false;
    }
}
