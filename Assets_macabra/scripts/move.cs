using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    private LayerMask wall;

    public float speed;
    float rotation = 0;

    private float check;

    void Start()
    {
        check = transform.localScale.z;
    }

    void Update()
    {
        float velocity = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W) && WalledUp() == false)
        {
            transform.Translate(Vector3.forward * velocity);
        }
        if (Input.GetKey(KeyCode.S) && WalledBack() == false)
        {
            transform.Translate(Vector3.back * velocity);
        }
        if (Input.GetKey(KeyCode.D) && WalledRight() == false)
        {
            transform.Translate(Vector3.right * velocity);
        }
        if (Input.GetKey(KeyCode.A) && WalledLeft() == false)
        {
            transform.Translate(Vector3.left * velocity);
        }

        float rotationInput = Input.GetAxisRaw("Mouse X");
        rotation += rotationInput;

        transform.localEulerAngles = new Vector3(0, rotation, 0);

        
    }

    private bool WalledUp()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), 1, wall))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool WalledBack()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), 1f, wall))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool WalledLeft()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), 1f, wall))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool WalledRight()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), 1f, wall))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
