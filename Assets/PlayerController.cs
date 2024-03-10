using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public PlayerController instance;
    public DamageReceiver dameReceiver;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        PlayerController.instance = this;

        this.dameReceiver = GetComponent<DamageReceiver>(); 
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
