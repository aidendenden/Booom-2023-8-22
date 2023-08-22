using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTriggerHand : MonoBehaviour
{
    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerHand")
        {
             gameObject.GetComponent<Animator>().SetTrigger("Jump");
            animator.SetTrigger("Change");
            Debug.Log("aa");
        }
        Debug.Log(collision.gameObject.tag);
    }
}
