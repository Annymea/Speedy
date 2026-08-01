using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 0;
    public Rigidbody2D player;
    public gameState gameState;
    public int deleteSpace = 10;

    void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("gameState").GetComponent<gameState>();
    }

    // Update is called once per frame
    void Update()
    {
        player.linearVelocityX = gameState.moveSpeed;
        if(gameObject.transform.position.x > deleteSpace)
        {
            Destroy(gameObject);
        }
    }

   
}
