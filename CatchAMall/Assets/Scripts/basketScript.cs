using UnityEngine;

public class basketScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.getkeyDown(left)){
            basket_x -= 0.01f;
        }
        if (input.getkeyDown(right)){
            basket_x +=0.01f;
        }
    }
}
