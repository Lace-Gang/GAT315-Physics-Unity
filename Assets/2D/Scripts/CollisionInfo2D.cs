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

    private void OnCollisionStay2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            material.color = Color.red;
        }
    }

    private void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            material.color = color;
        }
    }
}


