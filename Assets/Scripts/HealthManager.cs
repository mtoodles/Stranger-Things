using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private int numLives = 3;
    private int diff;
    private Text txt;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            diff = numLives - player.GetComponent<PlayerMovement>().deathCount;
            txt.text = "" + diff;
        }
        catch (MissingReferenceException e)
        {
            txt.text = "0";
        }
        
    }
}
