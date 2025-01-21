using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Vector3 acceleration;
    private Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        acceleration = new Vector3(0.0f, 0.0f, 0.0f);
        velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + velocity;
    }
}
