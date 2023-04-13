using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private AudioSource source;
    private ParticleSystem ps;
    private Renderer r;
    public GameObject gameObject;
    private KeepScore scoreScript;

    void Start()
    {
         r = GetComponent<Renderer>();
         source = GetComponent<AudioSource>();
         ps = GetComponent<ParticleSystem>();
         ps.Stop();
         gameObject = GetComponent<GameObject>();
         scoreScript = FindObjectOfType<KeepScore>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Player"))
        r.enabled = false;
        GameObject.Destroy(gameObject, 0.5f);
        source.Play();
        ps.Play();
        scoreScript.AddScore(5);

    }
}
