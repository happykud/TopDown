using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 5.0f;

    public GameObject player;

    //private void Update()
    //{
    //    //Vector3 dir = player.transform.position - this.transform.position;
    //    //Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
    //    //this.transform.Translate(moveVector);
    //}

    private void LateUpdate() // 물리 처리 후 업데이트 되는? 업데이트 중 가장 뒤? (렌더링, 카메라) 암튼 보여주는거, 내보내는거
    {
        Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }
}
