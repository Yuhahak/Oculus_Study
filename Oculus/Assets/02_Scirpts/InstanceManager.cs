using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstanceManager : MonoBehaviour
{
    public static InstanceManager s; // ������ ���� ���θ� �Ǵ��� ��ũ��Ʈ
    
    private void Awake()
    {
        s = this;
    }

    public bool ToyBoxOpen = false;
    public bool BallBox = false;
}