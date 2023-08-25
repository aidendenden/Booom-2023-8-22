using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustForCai : MonoBehaviour
{
    public AudioSource audioSource;
    public GoldMiner goldMiner;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CaiPoint"&&goldMiner.Have ==false)
        {
            goldMiner.Have = true;
            goldMiner.back = true;
            gameObject.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnDestroy()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
