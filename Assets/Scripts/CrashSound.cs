using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour
{

    public AudioClip crashSoft, crashHard;
    private AudioSource source;

    private float lowPitch = 0.5f, highPitch = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision coll)
    {

        float hitVol = coll.relativeVelocity.magnitude*0.2f;
        source.pitch = Random.Range(lowPitch, highPitch);
        if (coll.relativeVelocity.magnitude < 10)
             source.PlayOneShot(crashSoft, hitVol);
        else
                source.PlayOneShot(crashHard, hitVol);
            
        

    }
}
