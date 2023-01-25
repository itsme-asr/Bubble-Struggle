using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //[SerializeField] private Rigidbody2D rb;
    private float inputDirX;
    private float moveDirX;
    [SerializeField] private int speed = 12;

    private void Update()
    {
        inputDirX = Input.GetAxisRaw("Horizontal");
        moveDirX = inputDirX * speed * Time.deltaTime;
        transform.Translate(new Vector3(moveDirX, 0f, 0f));
    }

}
