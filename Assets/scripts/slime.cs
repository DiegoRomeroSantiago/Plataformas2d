using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class slime : MonoBehaviour
{
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;
    private SpriteRenderer spriteRendererr;

    [SerializeField] private Transform destinoActual;
    // Start is called before the first frame update
    void Start()
    {
        destinoActual = puntoB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destinoActual.position, velocidad * Time.deltaTime);

        if (transform.position == puntoA.position) 
        {
            spriteRendererr.flipX = true;
            destinoActual = puntoB;
        }
        
        if (transform.position == puntoB.position) 
        {
            spriteRendererr.flipX = false;
            destinoActual = puntoA;
        }
       
       
            
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.TryGetComponent(out Jugador playerScript))
        {
            collision.gameObject.GetComponent<Jugador>().RecibirDaño(daño);
        }
    }




}
