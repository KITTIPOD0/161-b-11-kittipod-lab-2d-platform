using UnityEngine;

public class character : MonoBehaviour
{

    public int health;
    public Rigidbody2D rb;
    public Animator anim;
    public HealthBar healthBarPrefab;   // พรีแฟ้บของหลอดเลือด
    private HealthBar healthBarInstance;
    [SerializeField] public float maxHealth = 100.0f;
   
   


    public void Intialize (int startHeath)
    {
        health = startHeath;
        Debug.Log($"{this.name} is intialize Heath : {this.health}");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

       
    }

    


    public void  TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"{this.name} took damage {damage}. Current Heath : {health}");
        
        IsDead();
    }
    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else { return false; };
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
