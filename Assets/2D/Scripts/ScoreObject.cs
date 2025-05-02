using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    [SerializeField] IntEventChannelSO scoreEvent;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] AudioSource sound;
    [SerializeField] int points = 10;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            scoreEvent.Raise(points);
            spriteRenderer.enabled = false;
            sound?.Play();
            GameObject.Destroy(this);
        }
    }
}
