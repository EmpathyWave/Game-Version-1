using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

//checks input fields for corresponding words in the story related to that character
//which is currently being interacted with
//then displays the proper result on the screen
public class StoryController : MonoBehaviour
{
    //input for People
    public InputField pInput;

    //input for Location
    public InputField lInput;

    private Story story;

    //loading in the json file 
    void Awake()
    {
        //TextAsset storyfile = Resources.Load<TextAsset>(path: "name_of_the_json");
        //story = new Story(storyfile.text);
    }
    
    //

    
        //
        //
    
    //story = new Story (inkJSONAsset.text);
    //Story story = (inkJSONAsset.text);

}
