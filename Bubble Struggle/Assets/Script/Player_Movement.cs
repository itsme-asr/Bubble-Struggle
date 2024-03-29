using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //[SerializeField] private Rigidbody2D rb;
    private float inputDirX;
    private float moveDirX;
    [SerializeField] private AudioSource point;
    [SerializeField] private GameObject fireEffect;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float speedBullet = 5f;
    [SerializeField] private int speed = 12;

    private void Update()
    {
        inputDirX = Input.GetAxisRaw("Horizontal");
        moveDirX = inputDirX * speed * Time.deltaTime;
        transform.Translate(new Vector3(moveDirX, 0f, 0f));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("audioPlay", .1f);
            GameObject cloneBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            cloneBullet.GetComponent<Rigidbody2D>().velocity = transform.up * speedBullet;
            deathEffect();
            Destroy(cloneBullet, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject.Find("Heart").transform.GetComponent<Heart>().loseLife();
        }
    }

    private void deathEffect()
    {
        GameObject death = Instantiate(fireEffect, transform.position, Quaternion.identity);
        Destroy(death, 1f);
    }
    public void audioPlay()
    {
        point.Play();
    }

}
