using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesCon : MonoBehaviour
{
    [Header("音效來源")]
    public AudioSource music;

    [Header("按鍵音效")]
    public AudioClip sound;

    public void Startgame()
    {
        music.PlayOneShot(sound);
        Invoke("delaystart", 1.0f);
    }
    public void delaystart()
    {
        SceneManager.LoadScene("stage01");
    }

    public void Goback()
    {
        music.PlayOneShot(sound);
        Invoke("delaygoback", 1.0f);
    }
    public void delaygoback()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Endgame()
    {
        music.PlayOneShot(sound);
        Invoke("delayendgame", 1.0f);
    }
    public void delayendgame()
    {
        Application.Quit();
    }
}
