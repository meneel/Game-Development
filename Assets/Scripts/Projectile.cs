using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpringJoint2D sp;
    public GameObject NextBall;
    private bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
    }

    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(0.15f);

        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(2f);
        if(NextBall != null)
        {
            NextBall.SetActive(true);
        }
        else
        {
            Application.LoadLevel(1);
        }
    }
}
