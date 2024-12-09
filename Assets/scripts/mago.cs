using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mago : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject bola;
    [SerializeField] private Transform spawn;
    private Transform objetivo; 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private void LanzarBolaFuego() //esto es para lanzar la bola de fuego
    {

        //Vector3 objetivo = (objetivo.position - transform.position).normalized;
        GameObject bolaCopia = Instantiate(bola, spawn.position, Quaternion.identity);
        //bolaCopia.transform.right = objetivo;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            objetivo = collision.transform;
            anim.SetBool("atacar", true);
        }
    }private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objetivo = null;
            anim.SetBool("atacar",false);
        }
    }
}
