using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOne : MonoBehaviour
{
 public void Begin()
 {
    Debug.Log("Start");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
}
