using UnityEngine;
public class povorot : MonoBehaviour
{
    public float mouseSensitivity = 500f;
    private float xRotation = 0f;
    public static float z_camera;
    private Transform tran;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        tran = GetComponent<Transform>();
        z_camera = tran.rotation.z;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Вращение по оси Y (горизонтальное вращение)
        transform.parent.Rotate(Vector3.up * mouseX);

        // Вращение по оси X (вертикальное вращение)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}