
using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(6.2f,3.03f, 0);
    //public float smoothSpeed = 5f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}