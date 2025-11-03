using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public character character;
    
    private void Start()
    {
        healthBar.maxValue = character.health; ;
    }
    private void Update()
    {
        healthBar.value = character.health;
        healthBar.maxValue = character.maxHealth;
    }
}
