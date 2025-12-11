using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float followRange;
    [SerializeField] private float followSpeed;
    [SerializeField] private float attackRange;
    void Start()
    {
        
    }
    void Update()
    {
        Follow();
    }
    private void Follow()
    {
        var direction = (player.transform.position - transform.position).normalized;
        direction.y = 0f;
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < followRange && distance > attackRange)
        {
            transform.Translate(direction * followSpeed * Time.deltaTime, Space.World);
        }
    }
}
