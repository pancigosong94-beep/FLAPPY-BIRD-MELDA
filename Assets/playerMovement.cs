using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //neww

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb; //inialisasi
    public float jumpforce; //Jump loncat
    float score;

    public Text scoreText; //neww
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); //perkenalkan inialisasi
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score; //neww
        if (Input.GetMouseButtonDown(0)) //klik mouse kiri for pc / tap untuk hp
        {
            Rb.velocity = Vector2.up * jumpforce;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }
        if(collision.gameObject.tag =="pipa")
        {
            Destroy(gameObject);
        }
    }
}
