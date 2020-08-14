using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Debug.Log("I hit " + otherCollider.name);
        DealDamage();
        Destroy(gameObject);
        
    }
}
