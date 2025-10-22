using UnityEngine;

public class MouseAimCamera : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5f;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;

        // Mouse settings to lock in screen and make invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        transform.position = target.transform.position + (rotation * offset);

        transform.LookAt(target.transform);
    }
}
