using UnityEngine;

public class BalloonController : MonoBehaviour
{
    [SerializeField]
    private float scaleFactor = 1.2f;

    private float maxScale = 3f;

    private void Start()
    {
        if(scaleFactor <= 1)
        {
            print("The scale factor value is too small");
        }
    }

    private void OnMouseUp()
    {
        transform.localScale *= scaleFactor;

        if(transform.localScale.x >= maxScale)
        {
            Destroy(gameObject);
        }
    }
}