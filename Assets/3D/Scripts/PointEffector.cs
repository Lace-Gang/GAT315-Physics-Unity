using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PointEffector : MonoBehaviour
{
    //when objects enter sphere if they are positive pull values, push them out, if negative pull them in 
    //one version pushes out with same force
    //one version applies more force the closer to center point one is

    [SerializeField] float radius = 1.0f;
    [SerializeField] LayerMask layerMask = Physics.AllLayers;
    [SerializeField] bool constantForce = true;

    Vector3 centerPoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        centerPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //WaitForFixedUpdate;
        var collection = Physics.OverlapSphere(this.transform.position, radius, layerMask);
        foreach(var collider in collection)
        {
           //Debug.Log(collider.tag);
            Pushable pushable = null;
            collider.TryGetComponent<Pushable>(out pushable);
            if(pushable != null)
            {
                pull(collider);
            }
        }
    }

    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    
    
    private void pull(Collider collider)
    {
       //get self center point
       //get gameobject
       //get pullvalue
    
       Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();
       Vector3 itemPosition = collider.gameObject.transform.position;
       Vector3 direction = itemPosition - centerPoint;
    
       if(constantForce)
       {
           rb.AddForce(direction * collider.GetComponent<Pushable>().pushValue, ForceMode.Impulse);
       }
       else
       {
            //use magnitude of subtraction of the two positions
            rb.AddForce(direction * collider.GetComponent<Pushable>().pushValue * direction.magnitude, ForceMode.Impulse);
        }
    
    }
}
