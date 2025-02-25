using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage; //por padrão, a variável booleana começa falsa. 
    
    [SerializeField] Color32 hasPackageColor = new Color32(34, 233, 23, 1);
    
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 1);

    [SerializeField] float pickupDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) //procedimento para o momento de colisão
    {
      Debug.Log("Oh shit!");
    }

    void OnTriggerEnter2D(Collider2D other) //procedimento para gatilho em colisão
    {
         if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, pickupDelay * Time.deltaTime);
        }

          if (other.tag == "Costumer" && hasPackage) //true não é necessário nesta linha.
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

}
