using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOnClick : MonoBehaviour
{
    Rigidbody2D rb;
    private void OnMouseDown()
    {
        rb.isKinematic = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
