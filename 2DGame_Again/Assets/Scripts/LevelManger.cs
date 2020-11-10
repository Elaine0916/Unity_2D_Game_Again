
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
    public void NextLevel(string NameLv)
    {
        SceneManager.LoadScene(NameLv);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
