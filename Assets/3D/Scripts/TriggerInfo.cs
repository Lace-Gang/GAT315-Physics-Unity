using UnityEngine;

public class TriggerInfo : MonoBehaviour
{
    Material material;
    Color color;


    void Start()
    {
        material = GetComponent<Renderer>().material;
        color = material.color;
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.tag == "Player")
        {
            material.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D Collider)
    {
        if(Collider.tag == "Player")
        {
            material.color = color;
        }
    }

 
}
