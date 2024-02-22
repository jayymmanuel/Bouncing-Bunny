using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public SpriteRenderer sr;
    public bool once = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && once)
        {
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.main.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

            once = false;
            Destroy(sr);
            Invoke(nameof(DestroyObj), dur);
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
