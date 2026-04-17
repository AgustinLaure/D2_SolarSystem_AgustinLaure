using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] float orbitSpeed;
    [SerializeField] Transform rotationAxis;
    [SerializeField] Vector2 rotationOffsetXY;
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
        orbit();
    }

    private void orbit()
    {
        angle += Time.deltaTime * orbitSpeed;
        Debug.Log(angle);
        Debug.Log(" ");

        if (angle >= 360)
        {
            angle = 0;
        }

        transform.position = new Vector3(rotationRadius * Mathf.Cos(angle-rotationOffsetXY.x), transform.position.y, rotationRadius * Mathf.Sin(angle- rotationOffsetXY.y));
    }
}
