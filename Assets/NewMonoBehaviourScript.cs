using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string choice = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Scissors()
    {
        choice = "Scissors";
        Debug.Log(choice);
    }
    private void Rock()
    {
        choice = "Rock";
        Debug.Log(choice);
    }
    private void Paper()
    {
        choice = "paper";
        Debug.Log(choice);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
