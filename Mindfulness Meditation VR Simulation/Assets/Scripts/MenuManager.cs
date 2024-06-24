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
        // Assign the button click events
        startGameButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace with your game scene name
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
