using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 0;
    //public bool isRunning = true;
    public Text text;
    float starttime =60;
    // Start is called before the first frame update
    void Start()
    {
        time = starttime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time = time - 1 * Time.deltaTime;
            text.text = time.ToString();
        }
        if (time<= 0)
        {
            SceneManager.LoadScene(3);
        }

    }
  
}
