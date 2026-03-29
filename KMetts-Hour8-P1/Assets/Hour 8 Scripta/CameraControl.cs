using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");

        transform.Translate(new Vector3(moveX, moveY, 0) * speed * Time.deltaTime);
    }
}
