using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

using TMPro;

public class MenuManager : MonoBehaviour
{
    public GameObject menuContainer;
    public GameObject higschoreContainer;

    public TextMeshProUGUI nameField;
    // Start is called before the first frame update
    void Awake()
    {
        //load data
    }

    public void StartGame(){
        //load the main scene
        SceneManager.LoadScene(1);
        //assign name to player in data manager
        DataManager.Instance.playerName = nameField.text;
    }

    public void Exit(){
        //save data
        //exit game
# if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
# else
        Application.Quit();
# endif
    }

    public void displayHighscores(){
        //swap out buttons for highscore list
    }

    public void displayMenu(){
        //swap out high score list for bbuttons
    }
}
