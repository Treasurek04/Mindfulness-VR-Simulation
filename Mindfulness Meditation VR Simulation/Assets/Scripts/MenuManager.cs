using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button startGameButton;
    public Button optionsButton;
    public Button quitButton;

    void Start()
    {
        // Assign the main menu button click events
        startGameButton.onClick.AddListener(OpenEnvironmentSelection);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);
    }

    void OpenEnvironmentSelection()
    {
        SceneManager.LoadScene("EnvironmentSelectionScene");
    }

    void OpenOptions()
    {
        // Handle options menu logic here
        Debug.Log("Options menu opened");
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
