using UnityEngine;

public class TriggerInfo2D : MonoBehaviour
{
    Material material;
    Color color;


    void Start()
    {
        material = GetComponent<Renderer>().material;
        color = material.color;
    }

    private void OnTriggerEnter(Collider2D other)
    {
        if (other.tag == "Player")
        {
            material.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider2D other)
    {
        if (other.tag == "Player")
        {
            material.color = color;
        }
    }
}
