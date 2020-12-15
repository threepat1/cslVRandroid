using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public GameObject engPopup, thaiPopup, mainMenu;

    public void PopUp1()
    {
        engPopup.SetActive(true);
        thaiPopup.SetActive(false);
        mainMenu.SetActive(false);
    }
    public void PopUp2()
    {
        engPopup.SetActive(false);
        thaiPopup.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void Cancel()
    {
        engPopup.SetActive(false);
        thaiPopup.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void GoToVideo1()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToVideo2()
    {
        SceneManager.LoadScene(3);
    }

}
