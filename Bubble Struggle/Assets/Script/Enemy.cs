using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject preFab1;
    //[SerializeField] private int speed = 7;
    //[SerializeField] private GameObject preFab2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            splitBubble();
        }
    }


    private void splitBubble()
    {
        GameObject bubblee = Instantiate(preFab1, transform.position, Quaternion.identity);
        //bubblee.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        Destroy(gameObject);
    }
}
