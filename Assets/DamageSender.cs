using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    protected EnemyController enemyController;
    private void Awake()
    {
        this.enemyController = GetComponent<EnemyController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        damageReceiver.Receive(1);

        this.enemyController.despawner.Despawn();


        Debug.Log(collision.name);
    }
}
