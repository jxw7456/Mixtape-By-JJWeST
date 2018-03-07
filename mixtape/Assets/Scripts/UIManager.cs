using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour {

    GameObject[] pauseObjects;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1.0f;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        HidePaused();
    }

    // Update is called once per frame
    void Update()
    {
        // Uses the ESC button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1.0f)
            {
                Debug.Log("Paused");
                Time.timeScale = 0.0f;
                ShowPaused();
            }
            else if (Time.timeScale == 0.0f)
            {
                Debug.Log("Play");
                Time.timeScale = 1.0f;
                HidePaused();
            }
        }
    }
    
    // Reloads the Level
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }

    // Controls the pausing of the scene
    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ShowPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            HidePaused();
        }
    }

    // Shows objects with ShowOnPause tag
    public void ShowPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    // Hides objects with ShowOnPause tag
    public void HidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    // Loads inputted level
    public void LoadLevel()
    {
        // Brings game back to main menu        
        if (SceneManager.GetActiveScene().buildIndex == 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quits the Game
    public void Quit()
    {
        Application.Quit();
    }

    // Go to options menu
    public void OptionsMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
