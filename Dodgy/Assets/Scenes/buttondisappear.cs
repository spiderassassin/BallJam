using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttondisappear : MonoBehaviour
{
    public GameObject cont;
    public GameObject start;

    // Start is called before the first frame update
    public void dis()
    {
        cont.SetActive(true);
        start.SetActive(false);
}
}
