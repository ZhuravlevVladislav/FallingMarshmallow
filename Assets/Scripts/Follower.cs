using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject followedObject;

    private void Update()
    {
        transform.position = new Vector3(0, followedObject.transform.position.y - 4, -10);
    }
}
