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

    public bool J_Block = false;
    public bool U_Block = false;
    public bool L_Block = false;
    public bool I_Block = false;
    public bool A_Block = false;

    
}
