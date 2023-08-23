using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustForENGlass : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerGalss")
        {
           
            animator.SetTrigger("Change");
            audioSource.PlayOneShot(audioSource.clip);
            Debug.Log("aa");
        }
        Debug.Log(collision.gameObject.tag);
    }
}
