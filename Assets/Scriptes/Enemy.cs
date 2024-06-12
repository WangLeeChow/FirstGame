using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    [SerializeField] private float timer = 5;
    [SerializeField] private AudioClip damageSoundClip;
    private float bulletTime;

    private AudioSource audioSource;


    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;
    [SerializeField] float maxHealth = 3f;
    public float enemyhealth;

    private void Start()
    {
       enemyhealth = maxHealth; 
    }

   public void TakeDamage(float damageAmount)
   {
        enemyhealth -= damageAmount;

        SoundFXManager.instance.PlaySoundFXClip(damageSoundClip, transform, .7f);
        

        if(enemyhealth <=0)
        {

                Destroy(gameObject);

        }
   }


    void Update()
    {
        ShootAtPlayer();
        LookAtPlayer();
    }

    void ShootAtPlayer()
    {

        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);


            Destroy(bulletObj, 5f);

    }


    void LookAtPlayer()
    {
        transform.LookAt(player);
    }
   
}