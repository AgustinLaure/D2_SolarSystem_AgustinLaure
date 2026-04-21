using UnityEngine;

public class OrbitController : MonoBehaviour
{
    [SerializeField] private bool isOrbiting = true;
    [SerializeField] private float orbitSpeed;
    [SerializeField] private Transform rotationAxis;
    [SerializeField] private Vector2 rotationOffsetXY;
    private float angle;
    private float rotationRadius;

    private void Awake()
    {
        angle = 0f;
    }

    private void Start()
    {
        rotationRadius = Vector3.Magnitude(transform.position - rotationAxis.position);
    }

    private void Update()
    {
        Orbit();
    }

    private void Orbit()
    {
        if (isOrbiting)
        {
            angle += Time.deltaTime * orbitSpeed;

            if (angle >= 360)
            {
                angle = 0;
            }

            transform.position = new Vector3(rotationRadius * Mathf.Cos(angle - rotationOffsetXY.x), transform.position.y, rotationRadius * Mathf.Sin(angle - rotationOffsetXY.y));
        }
    }
}
