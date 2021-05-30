using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void instructions()
    {
        SceneManager.LoadScene(0);
    }
}