using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse_Look : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    [SerializeField] private Animator m_Animator;
    [SerializeField] private Attacking Attacking;

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
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Confined;
            mouseSensitivity = 0f;
            m_Animator.SetBool("Escape", true);
            Attacking.ItCan = false;
        }
    }
    public void Escaping()
    {
        m_Animator.SetBool("Escape", false);
        mouseSensitivity = 200f;
        Cursor.lockState = CursorLockMode.Locked;
        Attacking.ItCan = true;
    }
}
