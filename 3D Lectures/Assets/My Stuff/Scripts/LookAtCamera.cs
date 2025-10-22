using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject target;   // player

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }

}
