using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal.UIElements;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NoteControls : MonoBehaviour //handles note controls and when it should appear and not 
{
    public InputField inputf1;
    public InputField inputf2;
    public InputField inputf3;
    public InputField inputf4;
    
    private string text1 = "";
    private string text2 = "";
    private string text3 = "";
    private string text4 = "";
    
    public GameObject global;
    
    private bool editing = false;

    void Start()
    {
        global = GameObject.Find("Game Manager");
    }

    // Update is called once per frame
    void Update()
    {
        if (global.GetComponent<Global>().gameState == 1)
        {
            //display notes
            AControls();
        }
        else if (global.GetComponent<Global>().gameState == 2) 
        {
            //editing notes controls
        }
        else
        {
            //deactivate notes but save all text
        }
    }

    void AControls()
    {
        //checks if they are false and if they aren't then it activates game state 2
        if (inputf1.isActiveAndEnabled) // changes into editing
        {
            global.GetComponent<Global>().gameState = 2; // editing
            editing = true;
        }

        if (Input.GetKeyUp(KeyCode.N)) //exit out of notes
        {
            //deactivates panel 
            global.GetComponent<Global>().gameState = 0; //walking
        }

        if (Input.GetKeyUp(KeyCode.M)) //switch to map
        {
            //deactivates panel 
            global.GetComponent<Global>().gameState = 3; //map
        }
    }

    void EControls()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && editing == false)
        {
            global.GetComponent<Global>().gameState = 1; //back to notes
        }

        //put in editing the input fields here
    }
    
    void Esc() // overrides the function of escape normally
    {
        if (Input.GetKey(KeyCode.Escape) && editing == true)
        {
            inputf1.DeactivateInputField(); // 1
            inputf1.text = text1;
            inputf2.DeactivateInputField(); // 2
            inputf2.text = text2;            
            inputf3.DeactivateInputField(); // 3
            inputf3.text = text3;           
            inputf4.DeactivateInputField(); // 4
            inputf4.text = text4;
            
            editing = false;
        }
    }
    
    public void Save() // saving the text once the input field is called
    {
        if (editing == true)
        {
            text1 = inputf1.text;
            text2 = inputf2.text;
            text3 = inputf3.text;
            text4 = inputf4.text;
        }
    }
}
