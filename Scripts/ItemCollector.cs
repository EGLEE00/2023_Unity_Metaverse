using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public string targetTag = "item"; // 검사할 태그

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
        Debug.Log("게임 성공!");
        // 게임 성공 시 동작을 여기에 추가하세요.
    }
}
