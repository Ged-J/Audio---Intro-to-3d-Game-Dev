using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject projectile;
    public float shotSpeed = 2000f;

    public AudioClip shootSound;
    private AudioSource source;

    public float volLow =  0.5f;
    public float volHigh =  1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
        source = GetComponent<AudioSource>();


    }

    public void OnFire()
    {
        Shoot();
        PlaySound();
    }

    public void Shoot()
    {

        GameObject clone;
        clone = Instantiate(projectile,transform.position, transform.rotation);
        clone.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotSpeed);


    }

    public void PlaySound()
    {
        float volume = Random.Range(volLow,volHigh);
        source.PlayOneShot(shootSound, volume);
    }


}
