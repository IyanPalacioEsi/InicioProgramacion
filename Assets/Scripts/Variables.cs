using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Esta libreria contiene lo necesario para usar el motor Unity

/* Variable =`pequeña porcion de memoria Ram donde podemos guardar un valor, que puede ir cambiando
 * Declaracion de una variable -> (publica o privada), tipo, nombre(si son dos palabras, las escribimos juntas pero la segunda palabra empieza en mayuscula) = asignacion
 * Ejemplo
 * 
 * public tipo nombre = valor;
 * */

public class Variables : MonoBehaviour //MonoBehaviour significa que este Script deriva de ahi, en decir puede usar las propiedades de Unity
{
    /*
          * Iniciacion de variables
          */
    //Varoiable publica (accesibles desde el editor de Unity o desde otro Script)
    //int = numero de tipo entero sin decimales, positivo o negativo
    public int myNumber = 30;
    //Variable privada (solo son accesibles desde ente Script y se tienen en cuenta el lugar de definicion con respecto al codigo)
    // Si no ponemos public o private, automaticamente es private
    private int total; //Si no le asigno ningun valor a una variable de tipo int es como si hubiesemos puesto un 0

    //Se llama antes de que empiece el juego
    private void Awake()
    {
        //Pondríamos las variables o comportamientos que son necesarios antes de que comience el juego
    }

    //Se llama justo cuando empieza el juego
    // Start is called before the first frame update
    void Start()
    {
        //Pondríamos las variables o comportamientos que son necesarios una vez el juego ha comenzado

        //A la variable total le asignamos el valor de (myNumber - 5)
        total = myNumber - 5; //total = 25;

        //Nos sirve para mostrar por consola el resultado de total en este caso
        Debug.Log(total);
        //Hago una suma que se va a mostrar en la consola
        Debug.Log(6 + 5);
        //Ponemos un mensaje que se muestra por la consola
        Debug.Log("Hola que tal");
        //Combinamos lo de arriba
        Debug.Log("Tu eres tonto?" + 2 + 2); 
    }

    //Se llama una vez cada frame
    // Update is called once per frame
    void Update()
    {
        //Pondriamos las variables o comportamientos que son necesarios mientras el juego se esta ejecutando
    }
}
