using UnityEngine;

public class rotateLight : MonoBehaviour
{
    public float rotationSpeed = 5f; // rotation speed

    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}