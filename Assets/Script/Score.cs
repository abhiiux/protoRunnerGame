using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI countDown;
    // Update is called once per frame
    void Update()
    {
       countDown.text = player.position.z.ToString("0"); 
    }
}
