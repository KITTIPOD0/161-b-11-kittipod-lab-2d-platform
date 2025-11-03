using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public character character;
    float maxHeath = 100.00f;
    
    private void Start()
    {
        healthBar.maxValue = character.health; ;
    }
    private void Update()
    {
        healthBar.value = character.health;
        healthBar.maxValue = maxHeath;
    }
}
