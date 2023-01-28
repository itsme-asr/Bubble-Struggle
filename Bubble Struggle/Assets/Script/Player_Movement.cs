using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //[SerializeField] private Rigidbody2D rb;
    private float inputDirX;
    private float moveDirX;
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
            GameObject cloneBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            cloneBullet.GetComponent<Rigidbody2D>().velocity = transform.up * speedBullet;
            deathEffect();
            Destroy(cloneBullet, 3f);
        }
    }

    private void deathEffect()
    {
        GameObject death = Instantiate(fireEffect, transform.position, Quaternion.identity);
        Destroy(death, 1f);
    }

}
