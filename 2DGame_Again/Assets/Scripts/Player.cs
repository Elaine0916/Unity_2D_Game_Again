
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject Final;

    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            Final.SetActive(true);
        }

        if (collision.tag == "櫻桃")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "櫻桃數量:" + count;
        }
        
    }

}
