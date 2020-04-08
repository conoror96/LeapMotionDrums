using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;

public class VoiceControl : MonoBehaviour {
    /*
    This script is used to exit to the main menu from in-game. It uses the UWP voice recognition api 
    It can also go to an easier or more difficulty settings level
    */
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    

    void Start()
    {
        actions.Add("exit", Exit);
        actions.Add("menu", Exit);
        actions.Add("next", Next);
        actions.Add("previous", Previous);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();  
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Exit()
    {
        // transform.Translate(1, 0, 0);
        print("menu");
        SceneManager.LoadScene("menu");
    }
    private void Next()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Easy")
        {
            SceneManager.LoadScene("medium");
        }
        else if (sceneName == "Medium")
        {
            SceneManager.LoadScene("hard");
        }
    }


    private void Previous()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Medium")
        {
            SceneManager.LoadScene("easy");
        }
        else if (sceneName == "Hard")
        {
            SceneManager.LoadScene("medium");
        }
    }
}
