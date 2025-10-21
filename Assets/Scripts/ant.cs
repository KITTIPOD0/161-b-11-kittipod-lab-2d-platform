using UnityEngine;

public class ant : Enemy
{

    [SerializeField]Vector2 velocity;
    public Transform[] MovePoint; 
    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
    private void FixedUpdate()
    {
        Behavior();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(20);
         
       DamageHit = 20;

        velocity = new Vector2(-1.0f,0.0f);

    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
