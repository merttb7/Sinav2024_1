using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class karakter : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float hiz = 5.0f;
    public float zipla = 5.0f;
    public float score = 0.0f;

    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        hareketettir();
    }
    void hareketettir()
    {   
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(UnityEngine.Vector2.left * (hiz * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(UnityEngine.Vector2.right * (hiz * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(UnityEngine.Vector2.up * (zipla*hiz* Time.deltaTime));
        }
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Puan"))
        {
            score++;
            Destroy(other.gameObject);
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       else if (other.gameObject.CompareTag("bitirme"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
  
}
