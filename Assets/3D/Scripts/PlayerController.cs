using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float jumpHeight = 2.0f;
    [SerializeField] LayerMask layerMask = Physics.AllLayers;

    Rigidbody rb;
    Vector3 force;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
    
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
    
        force = direction * speed;
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    
       ////how to write manual collision (more or less)
       //var colliders = Physics.OverlapSphere(transform.position, 2, layerMask);
       //foreach( var collider in colliders)
       //{
       //    Destroy(collider.gameObject);
       //}
       //
       ////Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 5, layerMask);
       //Debug.DrawRay(transform.position, transform.forward * 5, Color.yellow);
       //if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 5, layerMask))
       //{
       //    Destroy(hit.collider.gameObject);
       //}
    }
    
    private void FixedUpdate() //ALWAYS do continuous steps (such as applying force) in Fixed Update WITH THE EXCEPTION of intantanious forces such as jumping (which I suppose would not be continuous)
    {
        rb.AddForce(force, ForceMode.Force);
        //rb.AddTorque(Vector3.up); //this is how to rotate via rigid body
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 2);
    }
}
