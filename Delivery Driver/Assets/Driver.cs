using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Driver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] float steeringSpeed = 250f;
    
    [SerializeField] float moveSpeed = 10f; //SerializeField deixa o campo disponível para edição no unity.
    
    [SerializeField] float slowSpeed = 5f;
    
    [SerializeField] float boostSpeed = 20f;

    [SerializeField] float baseSpeed = 10f;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) //procedimento para o momento de colisão
    {
      moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "speedBooster")
        {
            moveSpeed = boostSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime; 
        //Neste caso, Time.deltaTime está multiplicando 0,1 a velocidade para que ela tenha o mesmo valor independente da máquina.
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0 , -steerAmount); 
        transform.Translate(0, speedAmount, 0);
    }
}
