using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform transform;
    Vector3 cursorPos;

    [SerializeField]
    float speed = 10;
    bool ismoving = false;

    

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        Debug();
        Movement();
    }
    void Movement()
    {
        cursorPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        if (Input.GetButtonDown("Fire1"))
        {
            while (cursorPos.x > transform.position.x);
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, 0, 0);
                print(cursorPos.x);
            }
            //transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, 0, 0);
        }
    }
    void Debug()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            print(cursorPos.x);
        }
    }
}
