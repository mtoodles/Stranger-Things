using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DestroyAll("DontDestroy");
        DestroyAll("Player");
    }

    void DestroyAll(string tag)
    {
        GameObject[] objArr = GameObject.FindGameObjectsWithTag(tag);
        for(int i = 0; i < objArr.Length; ++i)
        {
            GameObject.Destroy(objArr[i]);
        }
    }
}
