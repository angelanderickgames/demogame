using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Gravedad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Planeta.planeta.objetos.Add(GetComponent<Rigidbody>());
		// pene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
