using UnityEngine;

public class WinZone : MonoBehaviour
{
    [SerializeField] EventChannelSO gameWinEvent;


    //private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        gameWinEvent.Raise();
    //    }
    //}



    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            gameWinEvent.Raise();
        }
    }
}
