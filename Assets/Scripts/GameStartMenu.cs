using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject scenesMenu;
    public GameObject options;
    public GameObject about;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button optionButton;
    public Button aboutButton;
    public Button quitButton;

    [Header("Scenes Menu Buttons")]
    public Button acrophobiaButton;
    public Button nictophobiaButton;
    public Button talassophobiaButton;

    public List<Button> returnButtons;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        startButton.onClick.AddListener(EnableScenes);
        optionButton.onClick.AddListener(EnableOption);
        aboutButton.onClick.AddListener(EnableAbout);
        quitButton.onClick.AddListener(QuitGame);

        acrophobiaButton.onClick.AddListener(() => StartGame(1));
        nictophobiaButton.onClick.AddListener(() => StartGame(2));
        talassophobiaButton.onClick.AddListener(() => StartGame(3));

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame(int sceneNumber)
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(sceneNumber);
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
        scenesMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(false);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
        scenesMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(false);
    }
    public void EnableScenes()
    {
        mainMenu.SetActive(false);
        scenesMenu.SetActive(true);
        options.SetActive(false);
        about.SetActive(false);
    }
    public void EnableOption()
    {
        mainMenu.SetActive(false);
        scenesMenu.SetActive(false);
        options.SetActive(true);
        about.SetActive(false);
    }
    public void EnableAbout()
    {
        mainMenu.SetActive(false);
        scenesMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(true);
    }
}
