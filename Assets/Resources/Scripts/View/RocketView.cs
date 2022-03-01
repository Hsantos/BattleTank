using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RocketView : MonoBehaviour {
    
    private Rigidbody2D body;
    private float speed = 10f;
    private Vector3 direction;
    private void Awake() {
        body = GetComponent<Rigidbody2D>();
    }

    public void Launch(Transform originTransform) {
        direction = -originTransform.up;
        body.AddForce(direction * speed, ForceMode2D.Impulse);
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<WallView>()!=null) {
            
            Debug.Log("Rocket hit wall");
            body.velocity = Vector2.zero;
            Quaternion rot = transform.rotation;
            transform.rotation = new Quaternion(rot.x,rot.y,rot.z*-1,rot.w);
            
            
            direction = new Vector3(direction.x*-1,direction.y, direction.z);
            body.AddForce(direction * speed, ForceMode2D.Impulse);
            
        } else if(collision.gameObject.GetComponent<BallView>()!=null){
            Debug.Log("Rocket hit ball");
            Destroy(gameObject);
        }
       
    }
}
