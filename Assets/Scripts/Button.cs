using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.XR;
using UnityEngine;

public class Button : MonoBehaviour
{
    //change to check for player tag
    //change from textBox
    [SerializeField] private TextMeshPro textBox;
    [SerializeField] private bool isPlayerCharacterNextToButton = false;

    [SerializeField] private GameObject boulderPrefab;
    [SerializeField] private Transform spawnPoint;
    private void Start()
    {
        textBox.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        textBox.enabled = true;
        isPlayerCharacterNextToButton = true;
    }

    private void OnTriggerExit(Collider other)
    {
        textBox.enabled = false;
        isPlayerCharacterNextToButton = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToButton)
        {
            Debug.Log("button has been pressed");

            Instantiate(boulderPrefab, spawnPoint.position, Random.rotation);
        }
    }
}