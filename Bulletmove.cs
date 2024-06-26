using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmove : MonoBehaviour
{
 public float Speed;
    public AudioClip Sound;

    private Rigidbody2D Rigidbody2D;
    private Vector3 Direction;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Grunt Grunt = other.GetComponent<Grunt>();
        jhonmove john = other.GetComponent<jhonmove>();
        if (Grunt != null)
        {
            Grunt.Hit();
        }
        if (john != null)
        {
            
		
        DestroyBullet();
    }}
     private void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.CompareTag("Player")) {
			GameManager.Instance.PerderVida();
		}
	}
}
