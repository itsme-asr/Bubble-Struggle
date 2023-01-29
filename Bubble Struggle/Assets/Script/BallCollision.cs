using UnityEngine;

public class BallCollision : MonoBehaviour
{

    [SerializeField] private GameObject effect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            deathEffect();
            other.GetComponent<Enemy>().splitBubble();
            //other.GetComponent<Enemy>().audioPlay();
        }

        else if (other.gameObject.tag == "Dball")
        {
            deathEffect();
            other.GetComponent<ballDestroy>().dead();
        }
    }

    private void deathEffect()
    {
        GameObject death = Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(death, 1f);
    }

}
