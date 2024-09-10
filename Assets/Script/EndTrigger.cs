
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GM;
void OnTriggerEnter ()
    {
     GM.CompleteLevel ();
  }
}
