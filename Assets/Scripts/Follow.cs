using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target; // Follow 대상
    public Vector3 offset; // 대상과의 거리

    void Update()
    {
        transform.position = target.position + offset; // 대상의 위치에 오프셋을 더하여 위치 설정
    }
}
