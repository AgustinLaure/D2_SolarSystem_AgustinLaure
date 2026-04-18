using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, controller.RotationDir);

        if (controller.GetIsAccel())
        {
            transform.position += transform.forward * (moveSpeed * Time.deltaTime);
        }
    }
}
