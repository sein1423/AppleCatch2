using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float dropSpeed = -.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, dropSpeed, 0f);
        if (transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }
}
