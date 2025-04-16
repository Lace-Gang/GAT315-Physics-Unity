using UnityEngine;
using UnityEngine.Timeline;

public class CollisionInfo : MonoBehaviour
{
    Material material;
    Color color;


    void Start()
    {
        material = GetComponent<Renderer>().material;
        color = material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            material.color = Color.red;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            material.color = color;
        }
    }
}
