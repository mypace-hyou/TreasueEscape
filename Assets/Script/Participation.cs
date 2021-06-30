using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Participation : MonoBehaviour
{
    public void LoadScen()
    {
        SceneManager.LoadScene("ExperimentScene");
    }
    public void End()
    {
        Application.Quit();
    }
}
