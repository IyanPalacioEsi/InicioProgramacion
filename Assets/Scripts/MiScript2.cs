using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript2 : MonoBehaviour
{
    /*Para poder acceder a una variable o metodo de otro script necesitaremos crear
     * una referencia de ese script en concreto
     */
    public MiScript1 instance; //instance es el nombre de la referencia

    // Start is called before the first frame update
    void Start()
    {
        //Mostramos por pantalla miNumero que es una variable que esta en MiScript1
        Debug.Log(instance.miNumero);
        //Tambien podriamos hacer la llamada a un metodo del otro script
        //instance.NombreDelMetodo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
