using UnityEngine;

public class Streamer : MonoBehaviour
{
    [SerializeField] float force = 1.0f;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    
}
