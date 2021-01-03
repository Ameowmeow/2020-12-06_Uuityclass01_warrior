using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesCon : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("stage01");
    }

    public void Goback()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Endgame()
    {
        Application.Quit();
    }
}
