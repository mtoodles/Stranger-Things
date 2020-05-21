using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        GameObject[] objs2 = GameObject.FindGameObjectsWithTag("UI");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        GameObject[] objs3 = GameObject.FindGameObjectsWithTag("Player");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
