using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject settingsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SettingsButton()
    {
        settingsWindow.SetActive(true);
    }

    public void CloseSettingsWindows()
    {
        settingsWindow.SetActive(false);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(3);
    }

}
