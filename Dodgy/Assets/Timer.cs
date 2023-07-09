using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 0;
    //public bool isRunning = true;
    public Text text;
    float starttime = 120;
    // Start is called before the first frame update
    void Start()
    {
        time = starttime;
    }

    // Update is called once per frame
    void Update()
    {
        
        time = time - 1 * Time.deltaTime;
        text.text = time.ToString();

    }
  
}
