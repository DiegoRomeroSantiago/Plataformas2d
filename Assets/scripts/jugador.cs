using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Rigidbody2D rb;
    float hInput;
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] int fuerzaSalto;
    [SerializeField] private GameObject piesJugador;
    [SerializeField] private float radioPies;
    [SerializeField] private float vida;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Animator jugador;
    


    // Start is called before the first frame update
    void Start()
    {  
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        //if (Input.GetKeyDown(KeyCode.Space) && )

        if (hInput != 0 )
        {
            //set.Bool = jugador;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2 (0, 1) * fuerzaSalto, ForceMode2D.Impulse); 
        }

    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2 (hInput, 0) * fuerzaMovimiento, ForceMode2D.Force);
    }
    private bool EnSuelo()
    {
        Collider2D coll = Physics2D.OverlapCircle(piesJugador.transform.position, radioPies, queEsSuelo);
        if (coll != null)
        {
            return true;
        }
       else
        {
            return false;
        }
       
    }
    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(radioPies.position.radioPies);
    }
    public void RecibirDaño(float daño)
    {
        vida -= daño;
        Debug.Log(vida);
    }
}
