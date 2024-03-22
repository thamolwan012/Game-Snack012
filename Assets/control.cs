using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // ความเร็วของการเคลื่อนที่

    // Update is called once per frame
    void Update()
    {
        // เคลื่อนที่ตามแนวนอน (ซ้าย/ขวา)
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // เคลื่อนที่ตามแนวดิ่ง (ขึ้น/ลง)
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }
}
