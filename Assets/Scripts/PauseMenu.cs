using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool JeuEnPause = false;

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JeuEnPause)
            {
                Reprendre();
            }
            else
            {
                PauseJeu();
            }
        }
    }

    public void Reprendre()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        JeuEnPause = false;
    }

    void PauseJeu()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        JeuEnPause = true;
    }

    public void ChargeMenu()
    {
        JeuEnPause = false;
        FindObjectOfType<AudioManager>().StopPlaying("MusiqueParc");
        FindObjectOfType<AudioManager>().Play("MusiqueMenu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Debug.Log("sexe");
    }

    public void QuitteJeu()
    {
       Debug.Log("je fuis");
        Application.Quit();
    }
}
