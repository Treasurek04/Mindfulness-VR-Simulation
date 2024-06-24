using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnvironmentSelectionManager : MonoBehaviour
{
    public Button forestButton;
    public Button beachButton;

    void Start()
    {
        // Assign the environment selection button click events
        forestButton.onClick.AddListener(() => LoadEnvironment("ForestScene"));
        beachButton.onClick.AddListener(() => LoadEnvironment("BeachScene"));
    }

    void LoadEnvironment(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
