using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float RestartDelay=1f;
    bool gamehasended = false;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }


     public void EndGame()
    {
        if(gamehasended==false)
        {
        gamehasended=true;
        Debug.Log("GAME OVER");
        Invoke("Restart",RestartDelay);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
