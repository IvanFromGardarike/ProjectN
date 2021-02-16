using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform transform;
    Vector3 cursorPos;

    [SerializeField]
    float speed;
    public static bool ismoving = false;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        debugMethod();
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
            float distance = Mathf.Sqrt(Mathf.Pow(cursorPos.x - transform.position.x, 2));
            if(distance > 0.1f)
            {
                if(cursorPos.x > transform.position.x)
                    transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 
                                                    transform.position.z);
                else
                    transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 
                                                    transform.position.z);
            }
            else
                ismoving = false;
        }
    }
    private void debugMethod()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Debug");
        }
    }
}
