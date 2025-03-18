using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    private Transform next_position;

    private bool canWarp = true;

    private float time = 1.5f;

    void Update()
    {
        if (canWarp == false)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            canWarp = true;
            time = 1.5f;
        }
        print(time);
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.layer == 7 && canWarp == true && Input.GetKey(KeyCode.E))
        {
            next_position = collision.gameObject.GetComponent<altar>().similar;
            transform.position = next_position.position;
            canWarp = false;
            print("O próximo objeto é: " + next_position + "\nE ele fica nas cordenadas: " + next_position.position);
        }
    }
}
