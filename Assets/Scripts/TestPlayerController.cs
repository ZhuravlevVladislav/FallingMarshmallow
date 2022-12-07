using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    // public float speed = 3f;
    public float fallAcceleration = 9.8f;
    
    private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // Falling test
        transform.position += new Vector3(0, -fallAcceleration/1000, 0);
    }
}
