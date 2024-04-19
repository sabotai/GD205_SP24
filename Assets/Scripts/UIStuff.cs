using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIStuff : MonoBehaviour
{
    public GameObject pauseMenu;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            pauseMenu.SetActive(!pauseMenu.activeSelf);
        }
    }
    public TMP_InputField input;
    public void Quit(){
        Application.Quit();
    }

    public void ChangeScene(){

        SceneManager.LoadScene(int.Parse(input.text));
    }
}
