using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject botonPausa;

    public void pausa ()
    {
        if (Panel.active)
        {
            Time.timeScale = 1f;
            Panel.SetActive(false);
            botonPausa.SetActive(true);
            
        }
        else
        {
            Time.timeScale = 0f;
            Panel.SetActive(true);
            botonPausa.SetActive(false);

        }
    }
    public void inicio ()
    {
        SceneManager.LoadScene(0);
    }
}
