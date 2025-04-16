using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject item;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ///GameObject.Instantiate(item, transform);
            item.SetActive(true);
        }
    }
}
