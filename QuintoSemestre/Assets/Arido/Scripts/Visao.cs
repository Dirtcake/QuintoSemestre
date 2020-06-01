using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{
    float rotX = 0;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Player.free)
        {
            rotX -= Input.GetAxis("Mouse Y") * 100 * Time.deltaTime;
            rotX = Mathf.Clamp(rotX, -45, 45);
            transform.localEulerAngles = rotX * Vector3.right;
        }
    }
}
