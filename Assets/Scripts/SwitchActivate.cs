using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchActivate : MonoBehaviour
{
    public AudioClip switchClip;
    private bool isOn = false;

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (LayerMask.LayerToName(obj.gameObject.layer) == "Player" && !isOn)
        {
            AudioSource.PlayClipAtPoint(switchClip, transform.position);
            isOn = true;
        }
    }
}
