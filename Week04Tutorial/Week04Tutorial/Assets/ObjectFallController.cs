using UnityEngine;

public class ObjectFallController : MonoBehaviour
{
    float wait = 0.1f;
    public GameObject fallingObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Fall",wait,wait);
    }
    void Fall()
    {
        Instantiate(fallingObject, new Vector3(Random.Range(-10,10),10,0), Quaternion.identity);
    }
}
