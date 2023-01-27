using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject preFab1;
    //[SerializeField] private GameObject preFab2;
    [SerializeField] private Rigidbody2D rb;
    //[SerializeField] private int speed = 7;
    //[SerializeField] private GameObject preFab2;
    [SerializeField] private Vector2 startForce;
    private void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void splitBubble()
    {
        GameObject bubblee1 = Instantiate(preFab1, rb.position + Vector2.right / 4f, Quaternion.identity);
        GameObject bubblee2 = Instantiate(preFab1, rb.position + Vector2.left / 4f, Quaternion.identity);
        //bubblee.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        bubblee1.GetComponent<Rigidbody2D>().AddForce(new Vector2(-4, 0), ForceMode2D.Impulse);
        bubblee2.GetComponent<Rigidbody2D>().AddForce(new Vector2(4, 0), ForceMode2D.Impulse);
        Destroy(gameObject);
    }
}
