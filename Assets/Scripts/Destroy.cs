using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public GameObject Bird;
    public GameObject Pattern;
    public float health = 4f;
    public static int enemiesAlive = 0;

    private void Start()
    {
        enemiesAlive++;
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > health)
        {
            DIE();
        }
    }

    void DIE()
    {
        Instantiate(Pattern, transform.position, Quaternion.identity);
        enemiesAlive--;
        if(enemiesAlive<=0)
        {
            Debug.Log("LEVEL WON!");
        }
        Destroy(Bird);


    }

}
