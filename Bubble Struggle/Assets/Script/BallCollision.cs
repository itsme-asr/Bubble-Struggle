using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().splitBubble();

        }

        else if (other.gameObject.tag == "Dball")
        {
            other.GetComponent<ballDestroy>().dead();
        }
    }

}
