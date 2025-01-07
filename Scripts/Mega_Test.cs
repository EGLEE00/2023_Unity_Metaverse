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
        //DOtween은 Start 문에서 한 번 실행
        //문법 : DOVirtual.Float ( 시작하고 싶은 값 , 목표하는 값, 시간, 대리자(delegate) 양식 그대로 입력
        // value 는 시간에 맞춰 변화하는 값
        // 선언한 float mtAngle에 vlaue를 입력 => 시간에 맞춰 변화함
        DOVirtual.Float(0f, 1000f, 60 * 5, delegate (float value)
        {
            mtAngle = value;
        }).SetDelay(5f);
    }


    // Update is called once per frame
    void Update()
    {
        //update문에서 프레임마다 변하는 mtAngle 값을 실제 Twist Comp에 입력 
        mt.angle = mtAngle;

        //시간에 맞춰 스스로 변화 * 속도 (이것을 조절하면 원하는 속도로 변화)
        mb.angle += Time.deltaTime * mbSpeed;
        mn.Freq += Time.deltaTime * mbSpeed;
        mn.Strength.y += Time.deltaTime * mbSpeed;
    }
}
