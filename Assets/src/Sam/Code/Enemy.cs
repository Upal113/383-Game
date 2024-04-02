using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private GameObject player;

    [SerializeField] private float movespeed, viewdistance, increase;
    private float distance;

    
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();  

    }

    void FixedUpdate()
    {

        followPlayer();
        
    }

    void followPlayer()
    {
        Vector2 enemyPosition = new Vector2(this.transform.position.x, this.transform.position.y);

        distance = Vector2.Distance(this.transform.position, player.transform.position);
        Vector2 direction = player.transform.position - this.transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        if(distance <= viewdistance)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, movespeed * Time.deltaTime);
            this.transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

        
    }

    public void increaseEnemySpeed()
    {
        movespeed += increase;
        Debug.Log("Enemy Speed Increased, Current speed: " + movespeed);
        Invoke("increaseEnemySpeed", 5);
    }

}
