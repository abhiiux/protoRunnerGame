using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlComplte : MonoBehaviour
{
  public void NotLevelComplete () 
  { 
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
