using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting; //���־� ��ũ��Ʈ ���ӽ����̽� �߰�
using UnityEngine;

public class CallVStrigger : MonoBehaviour
{
    //���� ���ӿ�����Ʈ�� ������ �ִ� ���־� ��ũ��Ʈ ������Ʈ
    public ScriptMachine machine;
    //Variables ������Ʈ (���־�ũ��Ʈ�� ���� ������Ʈ��� Variables ������Ʈ�� �ڵ� �߰�)
    public Variables vsComp;
    //Variables ������Ʈ���� �޾ƿ� ���� Ȯ���ϱ� ���� ����
    public float a;


    // Start is called before the first frame update
    void Start()
    {
        //���� ������ �ִ� ���־� ��ũ��Ʈ ������Ʈ�� ��´�
        machine = GetComponent<ScriptMachine>();
        //�ۼ��� ��ũ��Ʈ�� ����Ƽ �̺�Ʈ�� �����Ѵ�. Ŀ�����̺�Ʈ�� C#���� �����ų �� ����.
        machine.TriggerUnityEvent("CallToCS");


        //���ӿ�����Ʈ�� Variables ������Ʈ�� ��´�
        vsComp = GetComponent<Variables>();
        //Variables ������Ʈ�� speedObj ������ ���� a ������ ��´�
        a = Variables.Object(vsComp).Get<float>("speedObj");

    }

    // Update is called once per frame
    void Update()
    {
        a = Variables.Object(vsComp).Get<float>("speedObj");
    }
}
