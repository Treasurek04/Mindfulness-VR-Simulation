using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button startGameButton;
    public Button optionsButton;
    public Button quitButton;

    public Canvas mainMenuCanvas; // Reference to the main menu canvas
    public Canvas environmentSelectionCanvas; // Reference to the environment selection canvas

    public Button forestButton;
    public Button beachButton;

    void Start()
    {
        // Assign the main menu button click events
        startGameButton.onClick.AddListener(ShowEnvironmentSelection);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);

        // Assign the environment selection button click events
        forestButton.onClick.AddListener(() => LoadEnvironment("ForestScene"));
        beachButton.onClick.AddListener(() => LoadEnvironment("BeachScene"));

        // Initially show the main menu and hide the environment selection menu
        mainMenuCanvas.gameObject.SetActive(true);
        environmentSelectionCanvas.gameObject.SetActive(false);
    }

    void ShowEnvironmentSelection()
    {
        mainMenuCanvas.gameObject.SetActive(false);
        environmentSelectionCanvas.gameObject.SetActive(true);
    }

    void LoadEnvironment(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
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
