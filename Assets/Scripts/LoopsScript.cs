using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*
         * FOREACH -> iterar sobre los elementos de una estructura de datos 
         * foreach (Type elementName in collection){
         *  //Código del bucle
         *  }
         *  Se va a necesitar un iterador, que es una variable o referencia que cambia de valor
         *  en cada recorrido del bucle
         */

        //Creamos una lista de nombres de estudiantes que luego podemos usar
        List<string> studentNames = new List<string>();
        studentNames.Add("Christian");
        studentNames.Add("Kate");
        studentNames.Add("Mia");
        studentNames.Add("Robert");

        Debug.Log("IMPRIMIENDO CON FOREACH");
        foreach (string person in studentNames)
        {
            //Que cada recorrido del bucle, person tiene un valor distinto
            Debug.Log(person);
        }

        //Vuestra nota
        int[] someInts = new int[] { 4, 8, 3, 0, 9, 6, 8, 7 }; //las notas
        int sum = 0; //suma total de las notas
        int n = someInts.Length; //numero de notas totales
        foreach (int i in someInts) 
        {
            //sum = sum + i <-> sum += i;
            sum = sum + i; //El valor total de la suma en cada interacion del bucle 
            Debug.Log("La suma vale ahora: " + sum);
        }
        Debug.Log("La media de las notas vale: " + sum / n);

        /* 
         * FOR -> acceder a posiciones
         * for (inicializacion; condicion de continuacion; interador)
         * {
         *  //Codigo del bucle
         *  }
         */
        Debug.Log("IMPRIMIENDO CON EL FOR");
        Debug.Log("Contar de 1 a 10");
        for (int i = 1; i <= 10; i++) //i++ <-> i = i + 1 <-> i += 1
        {
            Debug.Log(i);
        }

        Debug.Log("Contar de 10 a 0");
        for(int i = 10; i >= 0; i --) 
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
