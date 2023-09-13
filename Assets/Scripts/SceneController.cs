using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance { get; private set; }
    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadDayScene()
    {
        SceneManager.LoadScene(Constants.DayScene);
    }

    public void LoadNightScene()
    {
        SceneManager.LoadScene(Constants.NightScene);
    }
}
