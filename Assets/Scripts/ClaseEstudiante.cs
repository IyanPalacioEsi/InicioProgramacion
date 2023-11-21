using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseEstudiante : MonoBehaviour
{
    public string nombre = "Iyán";
    public int edad = 18;
    public float clase = 3.1f;
    public string curso = "Diseño y desarrollo de videojuegos";

    // Start is called before the first frame update
    void Start()
    {
        Name("Iyán");
        Age(18);
        Class(3.1f);
        Course("Diseño y desarrollo de videojuegos");
    }

    // Update is called once per frame
    void Update()
    {
         //para saber cuanto tiempo esta el juego en marcha y mostrarlo por consola
        //Debug.Log(Time.time); //time = tiempo que ha pasado un frame hasta que termina 

        //Calculamos la altura a la que se encuentra el GameObject que tiene el script asociado
        float testObjectHeight = this.transform.position.y; //leer al reves (this = objeto donde esta metido el script)
        Debug.Log(testObjectHeight);
    }

    /* Metodo de Unity que funciona parecido al Update, es decir va a unos frames por segundo,
     * pero sus frames tienen el mismo tamaño. Pero es mas lento que el Update. Por ejemplo
     * en vez de ir a 30fps, va a 12-15 fps.
     * Sirve para hacer un movimiento suavizado al usar las fisicas
     */
    private void FixedUpdate()
    {
        Debug.Log(Time.time);
    }

    void Name(string nombre)
    {
        Debug.Log("Im " + nombre);
    }
    void Age(int edad)
    {
        Debug.Log("Im " + edad + " years " + " old");
    }
    void Class(float clase)
    {
        Debug.Log("Im " + " in " + clase + " class");
    }
    void Course(string curso)
    {
        Debug.Log("Im " + " in " + curso + " course");
    }
}
