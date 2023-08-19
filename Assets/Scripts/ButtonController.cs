using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.XR;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;
    [SerializeField] private bool isPlayerCharacterNextToButton = false;
    [SerializeField] private GameObject pressurePlate;

    //Ensures the text and the Player Character vicinty check are disabled at start.
    private void Start()
    {
        //... text and vicinty check are disabled.
        textBox.enabled = false;
        isPlayerCharacterNextToButton = false;
    }

    //When the Player Character are in the trigger zone the text and the vicinty check are enabled.
    private void OnTriggerEnter(Collider other)
    {
        //... text as well as vicinty check have been enabled.
        textBox.enabled = true;
        isPlayerCharacterNextToButton = true;
    }

    //When the Player Character Leaves the trigger zone the text is disabled and so is the player vicinity check.
    private void OnTriggerExit(Collider other)
    {
        //... text and vicinty check are disabled.
        textBox.enabled = false;
        isPlayerCharacterNextToButton = false;
    }
    private void Update()
    {
        //Checks if the player is pressing "E" and that the player is in the vicinty and if so removes the pressure plate and spikes Game Objects
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToButton)
        {
            //...spikes and pressure plate removed.
            Destroy(pressurePlate);
            DestroyInstantiatedSpikes();
            textBox.enabled = false;


        }
    }
    //Method allowing for the instantiated spikes to be found and destroyed when called.
    private void DestroyInstantiatedSpikes()
    {
        {
            PressurePlateController pressurePlateScript = FindObjectOfType<PressurePlateController>();

            if (pressurePlateScript != null && pressurePlateScript.instantiatedSpikes != null)
            {
                //... destroys spikes.
                Destroy(pressurePlateScript.instantiatedSpikes);
            }
        }
    }
}