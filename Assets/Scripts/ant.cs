using UnityEngine;

public class ant : Enemy
{

    [SerializeField]Vector2 velocity;
    public Transform[] MovePoint; 
    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
