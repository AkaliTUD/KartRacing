using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public void GoToPlay()
    {
        SceneManager.LoadScene("Play");
    }
    public void GoToControl()
    {
        SceneManager.LoadScene("Control");
    }
    public void GoToCode()
    {
        Application.OpenURL("https://github.com/AkaliTUD/KartRacing");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoToTrack1()
    {
        SceneManager.LoadScene("Track 1");
    }
    public void GoToTrack2()
    {
        SceneManager.LoadScene("Track2");
    }
    public void GoToTrack3()
    {
        SceneManager.LoadScene("Track3");
    }
}
