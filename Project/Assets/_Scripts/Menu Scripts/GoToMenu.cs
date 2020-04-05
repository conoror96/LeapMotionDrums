using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToMenu : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainMenu");
    }

}



