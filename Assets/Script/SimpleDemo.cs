using UnityEngine;

public class SimpleDemo : MonoBehaviour
{
    // [Attribute]
    // This makes it possible to adjust the movement speed in the editor.
    [SerializeField] private float speed = 2f;

    // [Property]
    // Ensures that the speed value cannot be set below zero.
    public float Speed
    {
        get { return speed; }
        set { speed = Mathf.Max(0f, value); }
    }

    // [Static]
    // Used here to count the total number of frames that have passed.
    public static int TotalTicks = 0;

    // [Update]
    // Moves the object forward and logs information periodically.
    void Update()
    {
        // Increment total frame count each frame
        TotalTicks++;

        // Move the object forward based on speed and frame time
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        // Every 60 frames, print a message in the Console (observable behavior)
        if (TotalTicks % 60 == 0)
        {
            Debug.Log("Moving... Speed = " + Speed + " | TotalTicks = " + TotalTicks);
        }
    }
}
