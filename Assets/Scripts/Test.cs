using UnityEngine;

public class Test : MonoBehaviour
{
    float Health;

    void Start()
    {
        Health = 20f;
    }

    void Update()
    {
        Health -= 0.1f;
        while (Health >= 0)
        {
            Debug.Log(Health);
        }
    }
}
