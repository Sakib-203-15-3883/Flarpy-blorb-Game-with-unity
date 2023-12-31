using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public GameObject gameOverScreen;




    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            logic.gameOverScreen.SetActive(true);
        }
        
    }
}
