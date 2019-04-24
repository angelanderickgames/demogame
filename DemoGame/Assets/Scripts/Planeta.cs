using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    public static Planeta planeta;
    public float fuerzaGravitacional;
    public List<Rigidbody> objetos;
    void Awake()
    {
        planeta = this;
     }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Rigidbody objeto in objetos)
        {
            Vector3 direccionGravedad = (objeto.transform.position - transform.position).normalized;
            Vector3 direccionObjeto = objeto.transform.up;
            objeto.AddForce(direccionGravedad * fuerzaGravitacional * Time.fixedDeltaTime);
            Quaternion nRotation = Quaternion.FromToRotation(direccionObjeto, direccionGravedad) * objeto.transform.rotation;
            objeto.transform.rotation = Quaternion.Slerp(objeto.transform.rotation, nRotation, 50 * Time.fixedDeltaTime);
        }
    }
}
