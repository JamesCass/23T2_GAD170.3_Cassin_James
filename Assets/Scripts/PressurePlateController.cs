using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PressurePlateController : MonoBehaviour
{
    [SerializeField] private GameObject spikesPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private TextMeshPro textbox;
    [SerializeField] private bool spikesAreTriggered = false;
                     public GameObject instantiatedSpikes;

    //Ensures text is disabled upon start
    private void Start()
    {
        //... text is set to disabled.
        textbox.enabled = false;
    }

    //Checks when the PlayerCharacter enters the trigger area AKA the "PressurePlate" then instantiates spikes infront of the Player Character and enables the text.
    private void OnTriggerEnter(Collider col)
    {
        //...checks to make sure only one set of spikes may be instantiated.
        if (spikesAreTriggered == false)
        {
            //...makes sure the object contains the tag "Player"
            if (col.CompareTag("Player"))
                //...instantiates spikes in desired position. 
                instantiatedSpikes = Instantiate(spikesPrefab, spawnPoint.position, Quaternion.Euler(1, 90, -50));
            //...enables text and enables spikes check.
            spikesAreTriggered = true;
            textbox.enabled = true;
        }
    }
    //When the Player Character leaves the trigger area disables the text.
    private void OnTriggerExit(Collider other)
    {
        //...text is disabled.
        textbox.enabled = false;
    }
}
