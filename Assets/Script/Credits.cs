using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
  public void Quit ()
  {
    Debug.Log(" Quit");
    Application.Quit();
  }
  public void Again ()
  {
   Debug.Log("again");
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
  }
}
