using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject ApplePrefabs, BombPrefabs,starPrefabs;
    public GameManager gm;
    public float span = 1.0f, delta = 0;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gs)
        {
            delta += Time.deltaTime;
            if (span < delta)
            {
                delta = 0;
                count++;
                int rand = Random.Range(1, 11);
                if (rand < 9)
                {
                    GameObject item = Instantiate(ApplePrefabs);
                    item.transform.position = new Vector3(Random.Range(-1, 2), 3, Random.Range(-1, 2));
                    
                }
                else if(rand == 9)
                {
                    GameObject item = Instantiate(starPrefabs);
                    item.transform.position = new Vector3(Random.Range(-1, 2), 3, Random.Range(-1, 2));
                    
                }
                else
                {
                    GameObject item = Instantiate(BombPrefabs);
                    item.transform.position = new Vector3(Random.Range(-1, 2), 3, Random.Range(-1, 2));
                    
                }
            }
        }
        if(count == 20)
        {
            span = 1.0f / 1.2f;
        }
        else if(count == 30)
        {
            span = 1.0f / 1.5f;
        }
        else if (count == 40)
        {
            span = 1.0f / 1.7f;
        }
        else if (count == 50)
        {
            span = 1.0f / 1.2f;
        }
    }
}
