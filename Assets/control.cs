using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // �������Ǣͧ�������͹���

    // Update is called once per frame
    void Update()
    {
        // ����͹������ǹ͹ (����/���)
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // ����͹������Ǵ�� (���/ŧ)
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }
}
