using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Transform john;

    void Update()
    {
        if (john != null)
        {
            Vector3 position = transform.position;
            position.x = john.position.x;
            transform.position = position;
        }
    }
}
