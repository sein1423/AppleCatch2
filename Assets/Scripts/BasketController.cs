using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, Mathf.Infinity))
        {
            float x = Mathf.RoundToInt(hit.point.x);
            float z = Mathf.RoundToInt(hit.point.z);
            transform.position = new Vector3(x, transform.position.y, z);
        }


        if (Input.GetMouseButton(0))
        {
            float x, z;
            if (Input.mousePosition.x >= 445)
            {
                x = 1;
            }
            else if(Input.mousePosition.x <= 366)
            {
                x = -1;
            }
            else
            {
                x = 0;
            }

            if (Input.mousePosition.y >= 222)
            {
                z = 1;
            }
            else if (Input.mousePosition.y <= 133)
            {
                z = -1;
            }
            else
            {
                z = 0;
            }
            transform.position = new Vector3(x, transform.position.y, z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Apple")
        {
            gm.AddPoint();
        }
        else if(other.tag == "star")
        {
            gm.AsPoint();
        }
        else
        {
            gm.MinusPoint();
        }
        Destroy(other.gameObject);
    }
}
