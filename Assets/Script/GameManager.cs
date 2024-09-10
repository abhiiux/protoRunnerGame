using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool GameEnded = false;
  public float DelayInRestart = 2f;

  public GameObject LevelCompleteUI;

  public void CompleteLevel()
  {
    LevelCompleteUI.SetActive(true);
  }
  public void EndGame ()
  {
    if (GameEnded == false)
    {
      GameEnded = true; 
      Debug.Log("Game Over!");
      Invoke("Restart", DelayInRestart);
    }
  }
  public void Restart ()
  {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
