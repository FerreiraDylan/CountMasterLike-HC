using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public Rigidbody rb;
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, transform.position.y, target.position.z), speed * Time.fixedDeltaTime);
        rb.MovePosition(pos);
        //transform.LookAt(target);
    }

    public void UnitDeath()
    {
        ParticleSystem clone = Instantiate(particle, transform.position, Quaternion.identity);
        particle.Play();
        Destroy(gameObject);
    }
}
