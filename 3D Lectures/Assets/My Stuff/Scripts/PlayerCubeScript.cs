using UnityEngine;

public class PlayerCubeScript : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float turningSpeed = 60f;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Rotate(0, horizontal, 0);
        transform.Translate(0, 0, vertical);
    }
}
