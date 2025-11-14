using UnityEngine;

public class SimpleDemo : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    public float Speed
    {
        get { return speed; }
        set { speed = Mathf.Max(0f, value); }
    }

    public static int TotalTicks = 0;

    void Update()
    {
        TotalTicks++;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (TotalTicks % 60 == 0)
        {
            Debug.Log("Moving. Speed=" + Speed + "  TotalTicks=" + TotalTicks);
        }
    }
}
