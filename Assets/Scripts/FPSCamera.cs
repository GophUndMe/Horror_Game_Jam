using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform pBody;
    float xRotation = 0f;
    public float maxLook1 = 90f;
    public float maxLook2 = 90f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -maxLook1, maxLook2);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        pBody.Rotate(Vector3.up * mouseX);
    }
}
