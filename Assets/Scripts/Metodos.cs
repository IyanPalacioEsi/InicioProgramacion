using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    /*
     * INICIALIZACIÓN DE VARIABLES
     */
    public int number1 = 5;
    public int number2 = 8;

    //string = cadena de caracteres que tenemos que asignarle a la variablo entre comillas dobles
    public string persona = "Antonio";
    public string persona2 = "Pablo";


    //float = numeros con parte decimal, al asignarle un valor debe acabar en f
    public float decimalNumber = 7.5f;


    // Start is called before the first frame update
    void Start()
    {
        //Llamamos al primer tipo de metodo para que funcione al empezar el juego
        AddTwoNumbers();
        //Llamamos al segundo tipo de metodo en el que le damos los valores que queremos pasarle entre paremtesis
        AddTwoNumbers2(6, 4); //El resultado será 10
        AddTwoNumbers2(8, 3); //El resultado será 11
        //Llamamos al tercer tipo de metodo
        Debug.Log(AddTwoNumbers3(3, 4)); //Este Debug.Log mostrara por consola el resultado de la suma, osea la variable result
        //Hay otra manera de hacer lo de arriba
        int suma = AddTwoNumbers3(3, 4); //Asi podriamos sacar el valor de result para usarlo en el metodo Start
        Debug.Log(suma);
        //Saludamos a las dos personas
        SayHello("Pablo", "Maria");
        //Multriplicar un numero decimal por dos
        DoubleNumber(3.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Primer tipo de metodo, que coge variables de fuera y hace su accion (lo que esta entre llaves)
    public void AddTwoNumbers()
    {
        //Cada vez que ejecutamos el metodo se sumarian las variables que hemos creando antes y se mostrarian por pantallas
        Debug.Log(number1 + number2);
    }

    //Segundo tipo de metodo, las variables se pasan al metodo por parametros y hace su acción cuando lo llamamos
    public void AddTwoNumbers2(int fistNumber, int secondNumber) //Los parametros son valores o referencias que le tenemos que pasar al metodo a la misma vez que lo llamamos para que funcione 
    {
        //Ahora se van a sumar los dos parametros que le hayamos pasado y se van a mostrar en pantalla
        Debug.Log(fistNumber + secondNumber);
    }

    //Tercer tipo de metodo, le pasamos parametro, el metodo tiene tipo de variable y devuelve una variable de ese tipo elegido
    public int AddTwoNumbers3(int firstNumber, int secondNumber)
    {
        //Creo una variable privada del metodo, para guardar el resultado de la suma
        int result = firstNumber + secondNumber;
        //Devuelvo el valor de la variable, que tiene que ser del mismo tipo que el del metodo
        return result;
    }

    /*
     * Un metodo que salude a la vez a dos personas dadas
     * Un metodo que multriplique un numero decimal por dos 
     * Ambos metodos se mostraran por consola
     */

    void SayHello(string userName , string userName2)
    {
        Debug.Log("Hello" + userName + "y" + userName2);
    }

    void DoubleNumber(float number)
    {
        Debug.Log(2.0 * number);
    }

}
