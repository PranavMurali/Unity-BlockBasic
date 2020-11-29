using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Start()
    {
        
    }


    void Update()
    {
        transform.position = player.position + offset;
    }
}
