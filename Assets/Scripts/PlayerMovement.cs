using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum MoveType
    {
        IsKinematic,
        IsPhysicsBased
    };


    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerController controller;
    [SerializeField] private MoveType moveType = MoveType.IsKinematic;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private const float maxTorque = 1f;
    [SerializeField] private const float maxForce = 1f;

    private const float torqueClamp = 50;
    private const float forceClamp = 50;

    private void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            moveType = MoveType.IsKinematic;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            moveType = MoveType.IsPhysicsBased;
        }

        if (moveType == MoveType.IsKinematic)
        {
            KinematicMove();
        }
    }

    private void FixedUpdate()
    {
        if (moveType == MoveType.IsPhysicsBased)
        {
            PhysicsBasedMove();
        }
    }
    private void KinematicMove()
    {
        transform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, controller.RotationDir);

        if (controller.IsAccel)
        {
            transform.position += transform.forward * (moveSpeed * Time.deltaTime);
        }
    }

    private void PhysicsBasedMove()
    {
        rb.AddRelativeTorque(controller.RotationDir * rotationSpeed / torqueClamp, ForceMode.Force);

        if (controller.IsAccel)
        {
            rb.AddForce(transform.forward * moveSpeed, ForceMode.Force);
        }
    }
}
