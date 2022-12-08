using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    [Header("Put observable object")]
    public Transform observable;

    [Header("Displacement coordinates")] 
    public float[] coords = {0f, 0f, 0f};

    [Header("Freeze position")] 
    public bool[] freeze = { false, false, false };

    private void Update()
    {
        float[] observableCoords = {observable.position.x, observable.position.y, observable.position.z};
        
        for (int i = 0; i < observableCoords.Length; i++)
        {
            if (freeze[i]) { observableCoords[i] = 0f; }
        }
        
        transform.position = new Vector3(
            observableCoords[0] + coords[0], 
            observableCoords[1] + coords[1], 
            observableCoords[2] + coords[2]
            );
        
    }
}
