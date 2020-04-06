using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FingerDetector : MonoBehaviour {

	public void Option1()
    {
        print("Activated");
        SceneManager.LoadScene("freestyle");
    }
    public void Option2()
    {
        print("Activated");
        SceneManager.LoadScene("difficultymenu");
    }
    public void Option3()
    {
        print("Activated");
        SceneManager.LoadScene("menu");
    }
    public void DifficultyOption1()
    {
        SceneManager.LoadScene("easy");
    }
    public void DifficultyOption2()
    {
        SceneManager.LoadScene("medium");
    }
    public void DifficultyOption3()
    {
        SceneManager.LoadScene("hard");
    }
}
