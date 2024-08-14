using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject optionpanel;
    public GameObject creditpanel;

    public void Play(){
        SceneManager.LoadScene(1);
    }
    public void Options(){
        optionpanel.SetActive(true);
    }
    public void Credits(){
        creditpanel.SetActive(true);
    }
    public void BackO(){
        optionpanel.SetActive(false);
    }
    public void BackC(){
        creditpanel.SetActive(false);
    }
    public void Quit(){
        Application.Quit();
    }
}
