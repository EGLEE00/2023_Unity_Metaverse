using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody charRigidbody;

    void Start()
    {
        charRigidbody = GetComponent<Rigidbody>();
        // Rigidbody�� ����ϴ� ���
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.freezeRotation = true; // ������ ȸ���� �����ϴ�.
        }
    }

    void Update()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;

        charRigidbody.velocity = inputDir * moveSpeed;

        transform.LookAt(transform.position + inputDir);
    }
}