using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject secTeleport;

    public bool isRight;
    void Start()
    {
        if(secTeleport == null)
        {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(isRight)
            other.transform.position = new Vector3(secTeleport.transform.position.x + 1.5f, secTeleport.transform.position.y, 
                                                secTeleport.transform.position.z);
        else
            other.transform.position = new Vector3(secTeleport.transform.position.x - 1.5f, secTeleport.transform.position.y, 
                                                secTeleport.transform.position.z);
        PlayerMovement.ismoving = false;

    }
    void OnDrawGizmos()
    {   
        Gizmos.color = Color.green;
        if(secTeleport != null)
            Gizmos.DrawLine(transform.position, secTeleport.transform.position);
        //if(isRight)
            //Gizmos.DrawRay(transform.position, 5f);
        //else
            //Gizmos.DrawRay(transform.position, -5f);
    }
}
