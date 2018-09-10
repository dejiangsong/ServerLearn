using System.Collections;
using System.Collections.Generic;
using Common;
using ExitGames.Client.Photon;
using UnityEngine;

/// <summary>
/// Sample示例
/// </summary>
public class LoginRequest : RequestBase {

    [HideInInspector]
    public string Usernamee = "nekroz";
    [HideInInspector]
    public string Passwordd = "123456";


    public override void Start() {
        base.Start();
    }

    public override void DefaultRequest() {
        Dictionary<byte, object> data = new Dictionary<byte, object>();
        data.Add((byte)ParameterCode.Username, Usernamee);
        data.Add((byte)ParameterCode.Password, Passwordd);
        
        PhotonEngine.Peer.OpCustom((byte)OpCode, data, true);       // 发起请求
    }

    public override void OnOperationResponse(OperationResponse operationResponse) {
        Debug.Log(operationResponse.ReturnCode);
    }
}
