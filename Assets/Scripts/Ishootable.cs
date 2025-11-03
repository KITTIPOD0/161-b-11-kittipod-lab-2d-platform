
using UnityEngine;

public interface Isshoottable
{
    public GameObject Bullet {  get; set; }

    public Transform ShootPoint { get; set; }

    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    public void Shoot();
}
