using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    private LoginRequest loginRequest;


    private void Awake() {
        loginRequest = GetComponent<LoginRequest>();        // 得到游戏物体上登录请求脚本
    }

    // Use this for initialization
    void Update() {
        if (Input.GetMouseButtonDown(0))
            SendRequest();
    }

    void SendRequest() {
        loginRequest.DefaultRequest();      // 发起登录请求脚本的默认请求
    }
}
