using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
   [SerializeField]
    private GameObject player;
    void Start()
    {
        if(player == null)
        {

        }    
    }

    void Update()
    {
        camFollow();
    }
    private void camFollow()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 10f);
        transform.position = playerPos;
    }
}
