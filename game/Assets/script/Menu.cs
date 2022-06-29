using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject pause;
    public void PauseMenu()
    {
        pause.SetActive(true);
    }
    public void closePauseMenu()
    {
        pause.SetActive(false);

    }
    public void startMenu()
    {
        SceneManager.LoadScene(00);
    }
}
