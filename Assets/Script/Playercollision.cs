using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public box Movement;

    void OnCollisionEnter (Collision hitinfo) 
    {
      if(hitinfo.collider.tag == "Obstacle")
      {
        Movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
        
      }
    }
    
}
