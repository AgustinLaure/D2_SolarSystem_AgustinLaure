using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private bool isAccel = false;
    private Vector3 rotationDir;
    private bool isShoot = false;

    private void Awake()
    {
        isAccel = false;
        rotationDir = Vector3.zero;
    }
    private void Update()
    {
        isAccel = Input.GetKey(KeyCode.LeftShift);
        isShoot = Input.GetKey(KeyCode.F);

        rotationDir = new Vector3(-Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"), -Input.GetAxisRaw("Forward"));
    }

    public bool GetIsAccel() => isAccel;
    public Vector3 GetRotationDir() => rotationDir;

    public bool IsAccel { get { return isAccel; } }

    public bool SetIsAccel { set { isAccel = value; } }
   
    public Vector3 RotationDir { get { return rotationDir; } }

    public Vector3 SetRotationDir { set { rotationDir = value; } }
}
