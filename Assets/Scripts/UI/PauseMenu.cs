using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public static int isDashAssistOn = 1;
    public GameObject pauseMenuUI;

    public static string dashAssistKey= "DashAssist";



    void OnApplicationFocus(bool pauseStatus){
        if(!pauseStatus){
            Pause();
        }    
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Restart(){
        SceneManager.LoadScene(2);
    }

    public void Quit(){
        SceneManager.LoadScene(1);
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
