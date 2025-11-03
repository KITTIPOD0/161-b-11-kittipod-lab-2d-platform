using UnityEngine;

public class Player : character, Isshoottable
{

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform ShootPoint { get; set; }
    [field: SerializeField] public float ReloadTime { get ; set; }
    [field: SerializeField] public float WaitTime { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        base.Intialize(100);
        ReloadTime = 1.0f;
        WaitTime = 0.0f;
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }








    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
            Debug.Log($"{this.name} collides with {enemy.name}!");
        }
    }



// Update is called once per frame
private void  Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1")&& WaitTime >= ReloadTime)
        {
            var bullet = Instantiate(Bullet,ShootPoint.position,Quaternion.identity);
            Banana banana = bullet.GetComponent<Banana>();
            if (banana != null)
                banana.InitWeapon(100,this);
            WaitTime = 0.0f;
        }
    }
}
