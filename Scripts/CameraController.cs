
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        // 3분 후에 ActivateCameraScript 메소드를 호출
        Invoke("ActivateCameraScript", 90f); // 180초는 3분을 의미
    }

    void ActivateCameraScript()
    {
        // "Shader Effect_Corrupted Vram" 스크립트를 찾아 활성화
        ShaderEffect_CorruptedVram script = GetComponent<ShaderEffect_CorruptedVram>();

        if (script != null)
        {
            script.enabled = true;
        }
        else
        {
            Debug.LogError("Shader Effect_Corrupted Vram script not found!");
        }
    }
}

