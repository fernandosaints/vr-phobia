using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneLoader : MonoBehaviour
{

    public void NextSceneAcrophobia()
    {
        SceneManager.LoadScene("Acrophobia");
    }

    public void NextSceneNictophobia()
    {
        SceneManager.LoadScene("Nictophobia");
    }

    public void NextSceneThalassophobia()
    {
        SceneManager.LoadScene("Thalassophobia");
    }

    void Update()
    {
        //if (leftControllerReference.action.IsPressed())
        //{
        //    SceneManager.LoadScene("Menu");
        //}
    }
}
