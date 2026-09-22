using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SCR_DioramaCam : MonoBehaviour
{
    public Camera cam;

    public float sensitivity = 0.2f;

    public float horizontalAngle = 0f;
    public float verticalAngle = 20f;
    public float verticalLimit = 60f;

    public float zoomSpeed = 2f;
    public float minZoom = 0.5f;
    public float maxZoom = 2f;

       void Update()
    {
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        horizontalAngle += mouseDelta.x * sensitivity;

        verticalAngle -= mouseDelta.y * sensitivity;
        verticalAngle = Mathf.Clamp(
            verticalAngle,
            -verticalLimit,
            verticalLimit
        );

        transform.rotation = Quaternion.Euler(
            verticalAngle,
            horizontalAngle,
            0
        );
    }

}