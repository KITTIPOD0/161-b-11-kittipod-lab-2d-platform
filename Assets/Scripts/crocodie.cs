using Unity.VisualScripting;
using UnityEngine;

public class crocodie : Enemy,Isshoottable
{
    [SerializeField] private float atkRange;
    public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform ShootPoint { get; set; }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }



    public override void Behavior()
    {
        Vector2 distance = transform.position - player.transform.position;
        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s atk range!");
            Shoot();
            
        }
    }
    public void Shoot()
    {
        if(WaitTime>=ReloadTime)
        {
            anim.SetTrigger("Shoot");
            var bullet = Instantiate(Bullet,ShootPoint.position, Quaternion.identity);
            Rock rock = bullet.GetComponent<Rock>();
            rock.InitWeapon(30,this);
            WaitTime = 0;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        base.Intialize(50);
        DamageHit = 30;
        //set atk range and target
        atkRange = 6.0f;
        player = GameObject.FindFirstObjectByType<Player>();


        WaitTime = 0.0f;
        ReloadTime = 5.0f;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;

    }
    private void Update()
    {
        Behavior();
    }
}
