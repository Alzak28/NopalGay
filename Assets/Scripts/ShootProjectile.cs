using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    [SerializeField] private GameObject point; // Prefab anak panah
    [SerializeField] private float speed;

    public void FireProjectile()
    {
        GameObject projectile = Instantiate(point, transform.position, Quaternion.identity); // Instantiate anak panah
        projectile.GetComponent<Rigidbody2D>().AddRelativeForce(-this.transform.right * speed); // Berikan gaya untuk menembakkan anak panah

        // Tambahkan komponen Damageable pada anak panah
        Damageable damageable = projectile.AddComponent<Damageable>();
        damageable.SetDamage(10); // Set damage jika ingin

        // Mengatur collider untuk anak panah agar dapat mendeteksi tabrakan
        Collider2D collider = projectile.AddComponent<BoxCollider2D>(); // Atau jenis collider lain sesuai kebutuhan
        collider.isTrigger = true; // Pastikan collider adalah trigger agar bisa mendeteksi tabrakan
    }
}
