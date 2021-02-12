using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform transform;
    Vector3 cursorPos;

    [SerializeField]
    float speed;
    bool ismoving = false;

    int a = 0;

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
        if (Input.GetButtonDown("Fire1"))
        {
            ismoving = true;
            cursorPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ismoving = false;
        }
        if(ismoving)
        {
            if(cursorPos.x > transform.position.x)
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, 0, 0);
            else if(Mathf.Approximately(cursorPos.x, transform.position.x))
                ismoving = false;
            else if(cursorPos.x < transform.position.x)
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, 0, 0);
            else
                ismoving = false;
        }
    }
    void Debug()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            print(speed);
        }
    }
}
