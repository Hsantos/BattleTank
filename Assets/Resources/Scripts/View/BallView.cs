using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallView : MonoBehaviour {
    private Rigidbody2D body;
    private int force = 50;
    private int speed;
    private void Awake() {
        body = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("OnCollisionEnter2D Hit Ball");
        ReceiveHit(collision.transform.up * -1);
    }
    private void ReceiveHit(Vector2 direction) {
        speed += force;
        body.AddForce(direction * force, ForceMode2D.Impulse);
    }

    private void FixedUpdate() {
        if (speed > 0) {
            body.velocity -= 0.1f * body.velocity;
            speed--;
        }
    }
}
