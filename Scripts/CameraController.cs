
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        // 3�� �Ŀ� ActivateCameraScript �޼ҵ带 ȣ��
        Invoke("ActivateCameraScript", 90f); // 180�ʴ� 3���� �ǹ�
    }

    void ActivateCameraScript()
    {
        // "Shader Effect_Corrupted Vram" ��ũ��Ʈ�� ã�� Ȱ��ȭ
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

