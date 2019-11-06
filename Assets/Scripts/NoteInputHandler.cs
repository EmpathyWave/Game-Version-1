using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoteInputHandler : MonoBehaviour
//keeps track of note input for the various fields in the notebook
//goes in and ou of the note editing mode
{
    public InputField inputf1;
    public InputField inputf2;
    public InputField inputf3;
    public InputField inputf4;
    
    private string text1 = "";
    private string text2 = "";
    private string text3 = "";
    private string text4 = "";

    public Image map;

    //both functions placed into on value changed in the input field 
    //the script is meanwhile in the manager of the notebook scene

    void Update()
    {
        if (map.enabled == false && Input.GetKeyUp(KeyCode.M))
        {
            map.enabled = true;
        }
        else if (map.enabled == true && Input.GetKeyUp(KeyCode.M))
        {
            map.enabled = false;
        }
    }
    
    void Esc() // overrides the function of escape normally
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            inputf1.DeactivateInputField(); // 1
            inputf1.text = text1;
            inputf2.DeactivateInputField(); // 2
            inputf2.text = text2;            
            inputf3.DeactivateInputField(); // 3
            inputf3.text = text3;           
            inputf4.DeactivateInputField(); // 4
            inputf4.text = text4;
        }
    }
    
    public void Save() // saving the text once the input field is called
    {
        text1 = inputf1.text;
        text2 = inputf2.text;
        text3 = inputf3.text;
        text4 = inputf4.text;
    }
}
