using UnityEngine;

public class CollisionInfo2D
    : MonoBehaviour
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

    private void OnCollisionStay(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            material.color = Color.red;
        }
    }

    private void OnCollisionExit(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            material.color = color;
        }
    }
}


