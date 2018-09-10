1.介绍
    Unity与Photon通信，采用字典和操作码实现分发处理
    修改代码后，编译MyGameServer，会在\Photon-OnPremise-Server-SDK_v4-0-29-11263\deploy\MyGameServer\bin目录下生成应用程序的类库，需要将Common类库复制到\UnityToPhoton\UnityToPhotonClient\Assets\Plugins\目录下（同步2个公共类库）

2.其它
    用到的类库：(放置在\Photon-OnPremise-Server-SDK_v4-0-29-11263\lib\目录下)
        服务器端-MyGameServer：
            ExitGamesLibs.dll
            Photon.SocketServer.dll
            PhotonHostRuntimeInterfaces.dll
        客户端：
            Photon3Unity3D.dll
    配置文件：(放置在\Photon-OnPremise-Server-SDK_v4-0-29-11263\deploy\bin_Win64\PhotonServer.config)
        PhotonServer.config