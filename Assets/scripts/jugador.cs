using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    Rigidbody2D rb;
    float hInput;
    [SerializeField] int fuerzaMovimiento;
    [SerializeField] int fuerzaSalto;
    // Start is called before the first frame update
    void Start()
    {  
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2 (0, 1) * fuerzaSalto, ForceMode2D.Impulse); 
        }

    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2 (hInput, 0) * fuerzaMovimiento, ForceMode2D.Force);
    }

}
