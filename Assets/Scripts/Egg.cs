using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    public TextMeshPro degerText;
    GameManager gameManager;
    int deger, pozitiflik;

    private void Start()
    {
        gameManager=FindObjectOfType<GameManager>();   
        deger=Random.Range(1, 9);  
        pozitiflik=Random.Range(0, 3);
        if( pozitiflik==0 )
        {
            deger = -deger;
        }
        else {
            deger = deger ;
        }
        degerText.text=deger.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gameManager.score += deger;
            Destroy(gameObject);
        }
    }
}
