using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatShop : MonoBehaviour
{
    public Sprite ChangeImage;

    public List<Image> Heal = new List<Image>();
    public int healCount;

    public List<Image> HealTime = new List<Image>();
    public int healTimeCount;

    public List<Image> Damage = new List<Image>();
    public int damagedCount;

    public List<Image> Speed = new List<Image>();
    public int speedCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HealBtn()
    {
        if(healCount < 6)
        {
            healCount += 1;
            Heal[healCount - 1].sprite = ChangeImage;
        }
        
    }

    public void HealTimeBtn()
    {
        if (healTimeCount < 6)
        {
            healTimeCount += 1;
            HealTime[healTimeCount - 1].sprite = ChangeImage;
        }
    }

    public void DamageBtn()
    {
        if (damagedCount < 6)
        {
            damagedCount += 1;
            Damage[damagedCount - 1].sprite = ChangeImage;
        }
    }

    public void SpeedBtn()
    {
        if (speedCount < 6)
        {
            speedCount += 1;
            Speed[speedCount - 1].sprite = ChangeImage;
        }
    }
}
