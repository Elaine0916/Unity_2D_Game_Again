
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject Final;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送們惹");
        Final.SetActive(true);
    }

}
