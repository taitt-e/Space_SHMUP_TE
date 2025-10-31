using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is an enum of the various possible weapon type.s
/// It also includes a "shield" type to allow a shield PowerUp
/// Items marked [NI] below are Not Implemented in this book.
/// </summary>
public enum eWeaponType
{
    none, // The default / no weapon
    blaster, // A simple blaster
    spread, // Multiple shots simultaneously
    phaser, // [NI] Shots that move in waves
    missile, // [NI] Homing Missiles
    laser, //[NI] Damage over time
    shield // Raise shieldLevel
}
[System.Serializable]
public class WeaponDefinition
{
    public eWeaponType type = eWeaponType.none;
    [Tooltip("Letter to show on the Powerup Cube")]
    public string letter;
    [Tooltip("Color of Powerup Cube")]
    public Color powerUpColor = Color.white;
    [Tooltip("Prefab of Weapon model that is attached to the Player Ship")]
    public GameObject weaponModelPrefab;
    [Tooltip("Prefab of projectile that is fired")]
    public Color projectileColor = Color.white;
    [Tooltip("Damage casued when a single Projectile hits an Enemy")]
    public float damageOnHit = 0;
    [Tooltip("Damage caused per second by the Laser [Not Implemented]")]
    public float damagePerSec = 0;
    [Tooltip("Seconds to delay between shots")]
    public float delayBetweenShots = 0;
    [Tooltip("Velocity of individual Projectiles")]
    public float velocity = 50;
}
public class Weapon : MonoBehaviour
{

}
