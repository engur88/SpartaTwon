using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float cameraSpeed;   // cameraSpeed 값에 따라서 카메라 이동속도가 결정됨

    private void LateUpdate()   // LateUpdate는 Update함수가 호출된 후에 호출됨
    {
        //transform.position = new Vector3(player.position.x, player.position.y, -10f);
        // Vector3Lerp는 A와 B사이의 벡터 값을 반환
        transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * cameraSpeed);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);  // 카메라의 Z값을 -10f로 고정
    }
}