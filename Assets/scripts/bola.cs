using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private float fuerza;
    private int rebotes;
    private Animator anim;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * fuerza, ForceMode.Impulse);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private void Destruir()
    {
        Destroy(this.gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        rebotes++;
        if (rebotes == 3)
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            anim.SetTrigger("explosion");
        }
    }
} 
