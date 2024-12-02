using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;  // Required for Coroutines

public class LoadSceneOnButtonClick : MonoBehaviour
{
    public Toggle toggle1;  // Reference to the first toggle (for Scene 1)
    public Toggle toggle2;  // Reference to the second toggle (for Scene 2)
    public Toggle toggle3;
    public Button loadSceneButton;  // Reference to the button
    public float delay = 1f;  // Delay time in seconds

    void Start()
    {
        // Add listener to the button click
        loadSceneButton.onClick.AddListener(OnLoadSceneButtonClicked);
    }

    // Method called when the button is clicked
    void OnLoadSceneButtonClicked()
    {
        // Start the coroutine to load the scene with delay
        StartCoroutine(LoadSceneWithDelay());
    }

    // Coroutine to load the scene after a delay
    IEnumerator LoadSceneWithDelay()
    {
        // Check which toggle is selected and load the corresponding scene after the delay
        if (toggle1.isOn)
        {
            Debug.Log("Loading Acrophobia after " + delay + " seconds...");
            yield return new WaitForSeconds(delay);  // Wait for 1 second
            SceneManager.LoadScene("Acrophobia");  // Replace "Scene1" with the actual scene name
        }
        else if (toggle2.isOn)
        {
            Debug.Log("Loading Nictophobia after " + delay + " seconds...");
            yield return new WaitForSeconds(delay);  // Wait for 1 second
            SceneManager.LoadScene("Nictophobia");  // Replace "Scene2" with the actual scene name
        }
        else if (toggle3.isOn)
        {
            Debug.Log("Loading Thalassophobia after " + delay + " seconds...");
            yield return new WaitForSeconds(delay);  // Wait for 1 second
            SceneManager.LoadScene("Thalassophobia");  // Replace "Scene2" with the actual scene name
        }
        else
        {
            Debug.Log("No toggle is selected!");  // Optional: Handle cases where no toggle is selected
        }
    }
}
