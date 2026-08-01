using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameState : MonoBehaviour
{

    public float moveSpeed;
    public TextMeshProUGUI text;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setMoveSpeed(float newSpeed)
    {
        Debug.Log("New movespeed:" + newSpeed);
        moveSpeed = newSpeed;
        text.text = newSpeed.ToString();
    }
}
