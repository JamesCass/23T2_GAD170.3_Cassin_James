using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WarningTutorialController: MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;
    private void Start()
    {
        textBox.enabled = false;
    }
 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("a trigger has been triggered!");

        textBox.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        textBox.enabled = false;
    }
}
