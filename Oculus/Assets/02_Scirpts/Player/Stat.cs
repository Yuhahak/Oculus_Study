using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    public int hpUp; //기본 체력 증가
    public int hpTimeHeal; //시간마다 체력 회복
    public float damageUp; //공격력 증가
    public float moveSpeedUp; //이동속도 증가

    // Start is called before the first frame update
    void Start()
    {
        HpUp();
        DamagedUp();
    }

    // Update is called once per frame
    void Update()
    {
        HpTiemHeal();
    }

    public void HpUp()
    {
        GameManager.instance.player.hp += 200f * hpUp;
    }

    public void HpTiemHeal()
    {
        if(GameManager.instance.player.maxHp >= GameManager.instance.player.hp)
        {
            GameManager.instance.player.hp += 5f * hpTimeHeal * Time.deltaTime;
        }
    }

    public void DamagedUp()
    {
        GameManager.instance.player.damage += 2.5f * damageUp;
    }

    public void MoveSpeedUp()
    {
        //vr개발할때 추가
    }
}
