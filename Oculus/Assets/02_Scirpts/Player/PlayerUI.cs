using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;

    public Image hpBar;
    private float maxHp;

    private void Start()
    {
        maxHp = player.hp;
    }

    private void Update()
    {
        hpBar.fillAmount = player.hp / maxHp;
    }
}
