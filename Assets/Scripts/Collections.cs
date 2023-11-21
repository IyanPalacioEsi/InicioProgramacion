using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public string student1 = "Christian";
    public string student2 = "Kate";
    public string student3 = "Mia";
    public string student4 = "Robert";

    //Todas las estructuras de datos empiezan en la posición numero 0
    //El ultimo elemento de un array es el de su dimension -1

    /* 
     * ARRAY
     * -Es homogeneo (solo un tipo de dato)
     * -Es de tamaño fijo (una vez creado, no puede contener mas elmentos)
     * -Tiene un orden (se accede por posicion)
     */

    public string[] students = new string[] { "Christian", "Kate", "Mia", "Robert" };
    public string[] familyNames = new string[4]; // { , , , }
    int[] numberDoorsStreet = new int[] { 1, 2, 3, 4, };
    private bool[] hasPassedTheExam = new bool[] { true, false, true, false };

    /*
    *Listas
    *-Es homogenea (solo un tipo de dato)
    *-Es de tamaño ajustable o variable (podemos añadir mas elementos en tiempo real y eliminarlos)
    *-Tiene un orden (se accede por posicion)
    */

    public List<string> studentNames = new List<string>();

    /*
     * ARRAYLIST
     * -Es hetereogeneo (puede guardar diferentes tipos de datos en la misma estructura)
     * -Es de tamaño ajustable o variable (podemos añadir mas elementos en tiempo real y eliminarrlos)
     * -Tiene un orden (se accede por posicion)
     */

    public ArrayList inventory = new ArrayList();

    /*
     * DICCIONARIO <-> HASHTABLE
     *     * -Es hetereogeneo (puede guardar diferentes tipos de datos en la misma estructura)
     * -Es de tamaño ajustable o variable (podemos añadir mas elementos en tiempo real y eliminarrlos)
     * -Se accede por clave (no por posicion)
     */

    public Hashtable personalDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        /*
         * Listas
         */
        //ADD -> añade elementos a una lista al final de la lista
        //Aqui la lista esta vacia
        studentNames.Add("Christian");
        //Aqui ya tiene un elemento
        studentNames.Add("Kate");
        //Ahora hay 2
        studentNames.Add("Mia");
        //3
        studentNames.Add("Robert");
        //4
        studentNames.Add("Jack");
        //5

        //CONTAINS -> nos dice si la lista contiene o no un objeto
        if (studentNames.Contains("Jack")) 
        {
            //REMOVE -> elimina elementos de la lista
            studentNames.Remove("Jack");
        }

        //INSERT -> Podemos meter elementos nevos en la lista en una nueva posicion
        studentNames.Insert(2, "Paul");
        //Ahora el orden es Christian, Kate, Paul, Mia, Robert

        //TOARY() -> Convierte una lista en un array
        string[] studentNamesToArray = studentNames.ToArray();

        //CLEAR() -> Elimina definitivamente todos los elementos de la lista
        //studentNames.Clear();
        //Ahora la lista estara vacia

        /*
         * Acceso a arrays y tamaño de los mismos
         */
        //LENGTH -> Nos indica el tamaño del array
        Debug.Log("El tamaño del array de estudiantes es: " + students.Length);

        int pos = 0;
        //Comprobamos que la posicion que le pasamos este contenida en el array

        if(pos >= 0 && pos < students.Length) 
        {
            //Nos muestra la posicion que le hemos pasado en parametro students[posicion]
            Debug.Log("El primer estudiante del array es: " + students[pos]);
        }
        /*
         * Acceso a las listas y tamaño de las mismas
         */
        //Count -> Nos indica el tamaño de la lista
        Debug.Log("El tamaño de la lista de estudiantes es: " + studentNames.Count);

        pos = 2;
        if (pos >= 0 && pos < studentNames.Count) 
        {
            string thirdStudent = studentNames[pos];
            Debug.Log("El tercer estudiante de la lista es: " + thirdStudent);
        }

        /*
         * ARRAYLIST
         */

        inventory.Add(30);
        inventory.Add(3.14159265f);
        inventory.Add("Iyan");
        inventory.Add(false);
        //Buscamos un objeto en la escena que este etiquetado como Arma y lo guardamos en el ArratList
        inventory.Add(GameObject.FindGameObjectsWithTag("Arma"));

        //Pedimos tambien el tipo de dato que va a salir de la ArrayList
        Debug.Log(inventory[2].GetType());
        Debug.Log(inventory[4].GetType());

        /*
         * HASHTABLE
         */
        //Ponemos clave yb valor
        personalDetails.Add("firstName", "Iyan");
        personalDetails.Add("lastName", "Palacio Fernandez");
        personalDetails.Add("age", 18);
        personalDetails.Add("gender", "male");

        if (personalDetails.Contains("firstName") && personalDetails.Contains("age")) 
        {
            //Tenemos que hacer cast (Convertir un tipo de variable en otra para poder usarla)
            string name = (string)personalDetails["firstName"];
            int ageVariable = (int)personalDetails["age"];
            Debug.Log(name);
            Debug.Log(ageVariable);
        }
        else
        {
            Debug.Log("El diccionario no contiene las claves que se ha pedido");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
