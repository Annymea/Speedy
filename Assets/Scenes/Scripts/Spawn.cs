using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject newPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject existingPlayer = GameObject.FindGameObjectWithTag("Player");
        if (!existingPlayer)
        {
            Instantiate(newPlayer, new Vector3(transform.position.x, transform.position.y, transform.position.y), transform.rotation);
        }
    }
}
