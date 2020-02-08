using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("yo I'm a Player");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if (Mathf.Abs(horizontalMovement) > 0)
        {
            Debug.Log("horizontal: " + horizontalMovement);
        }

        if (Mathf.Abs(verticalMovement) > 0)
        {
            Debug.Log("vertical: " + verticalMovement);
        }
    }
}
