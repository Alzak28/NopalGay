using System;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Damageable : MonoBehaviour
{
    private int damage; // Menyimpan damage yang akan diberikan

    public void SetDamage(int damage)
    {
        this.damage = damage; // Set damage
    }

    internal object TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Target target = collision.GetComponent<Target>(); // Mencari komponen Target
        if (target != null)
        {
            target.TakeDamage(damage); // Berikan damage ke target
            Destroy(gameObject); // Hancurkan anak panah setelah memberikan damage
        }
    }
}
