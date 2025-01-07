using System.Collections;
using System.Collections.Generic;
using MegaFiers;
using UnityEngine;
using DG.Tweening;

public class Mega_Test : MonoBehaviour
{
    public float mbSpeed;
    public float mtAngle;
    public MegaBend mb;
    public MegaNoise mn;
    public MegaTwist mt;
    // public float delayTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //DOtween�� Start ������ �� �� ����
        //���� : DOVirtual.Float ( �����ϰ� ���� �� , ��ǥ�ϴ� ��, �ð�, �븮��(delegate) ��� �״�� �Է�
        // value �� �ð��� ���� ��ȭ�ϴ� ��
        // ������ float mtAngle�� vlaue�� �Է� => �ð��� ���� ��ȭ��
        DOVirtual.Float(0f, 1000f, 60 * 5, delegate (float value)
        {
            mtAngle = value;
        }).SetDelay(5f);
    }


    // Update is called once per frame
    void Update()
    {
        //update������ �����Ӹ��� ���ϴ� mtAngle ���� ���� Twist Comp�� �Է� 
        mt.angle = mtAngle;

        //�ð��� ���� ������ ��ȭ * �ӵ� (�̰��� �����ϸ� ���ϴ� �ӵ��� ��ȭ)
        mb.angle += Time.deltaTime * mbSpeed;
        mn.Freq += Time.deltaTime * mbSpeed;
        mn.Strength.y += Time.deltaTime * mbSpeed;
    }
}
