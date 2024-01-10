using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    public float rotationSpeed;
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime); //rotates 50 degrees per second around z axis
    }

}
