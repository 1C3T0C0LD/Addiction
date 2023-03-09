using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip collect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Play a sound effect
            GameObject.Find("SFX_Source").GetComponent<AudioSource>().PlayOneShot(collect);
            //Add to player score
            //Delete ourselves
            GameObject.Destroy(gameObject);
        }
    }
}

