using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public string targetTag = "item"; // �˻��� �±�

    void Update()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(targetTag);

        bool allObjectsActivated = true;

        foreach (GameObject obj in taggedObjects)
        {
            if (!obj.activeSelf)
            {
                allObjectsActivated = false;
                break;
            }
        }

        if (allObjectsActivated)
        {
            GameSuccess();
        }
    }

    void GameSuccess()
    {
        Debug.Log("���� ����!");
        // ���� ���� �� ������ ���⿡ �߰��ϼ���.
    }
}
