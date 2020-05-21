using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private bool objectExists = false;
    void Awake()
    {
        if (!objectExists)
        {
            objectExists = true;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
//Alternate code
//GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
//        if (objs.Length > 1)
//            Destroy(this.gameObject);
//GameObject[] objs2 = GameObject.FindGameObjectsWithTag("UI");
//        if (objs.Length > 1)
//            Destroy(this.gameObject);
//GameObject[] objs3 = GameObject.FindGameObjectsWithTag("Player");
//        if (objs.Length > 1)
//            Destroy(this.gameObject);
//DontDestroyOnLoad(this.gameObject);
