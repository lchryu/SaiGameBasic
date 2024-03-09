using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerController playerController;
    private void Awake()
    {
        this.playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        // this.CheckDead();

    }

    protected virtual void CheckDead()
    {
        if (this.playerController.dameReceiver.IsDead()) this.Dead();
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
