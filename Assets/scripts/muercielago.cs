using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muercielago : MonoBehaviour
{
    [SerializeField] private Transform ruta;
    private List<Transform> puntosRuta = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform punto in ruta)
        {
            puntosRuta.Add(punto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
