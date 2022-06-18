using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalButton : MonoBehaviour
{
    public void changeScene(int n)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + n);
    }

    public void startScene()
    {
        changeScene(-SceneManager.GetActiveScene().buildIndex);
    }
}