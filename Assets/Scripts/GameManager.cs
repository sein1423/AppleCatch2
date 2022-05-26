using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool gs = false;
    public Text point,timer;
    public float time = 60.0f;
    float starter = 3f;
    float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddPoint()
    {
        score += 100;
    }

    public void MinusPoint()
    {
        score /= 2;
    }

    public void AsPoint()
    {
        score *= 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (starter > 0)
        {
            starter -= Time.deltaTime;
            point.text = starter.ToString("F1") + " S";
            gs = false;
        }
        else
        {
            gs = true;
            time -= Time.deltaTime;
            timer.text = time.ToString("F1") + " S";
            point.text = score.ToString("F0") + " Point";
        }

        if (time <= 0)
        {
            SceneManager.LoadScene(1);
        }

    }
}
