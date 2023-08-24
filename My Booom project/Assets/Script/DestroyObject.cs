using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float destroyDelay = 5f;

    private void Start()
    {
        Invoke("DestroySelf", destroyDelay);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}