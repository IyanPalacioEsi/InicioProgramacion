using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int age;
    public bool isMale;
    public bool isMarried;

    public Persona spouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo al que le pasamor una persona para saber si esta casda con otra

    public bool IsMarriedWith(Persona otherPerson) 
    { 
        //Compruebo primero si esa persona esta casada o tiene esposo/a
        if (spouse == null) 
        {
            Debug.Log("No esta casado/a");
            return false;
        }
        else 
        {
            Debug.Log("Esta casado/a");
            if(otherPerson.firstName == spouse.firstName &&
                otherPerson.lastName == spouse.lastName) 
            {
                Debug.Log("Estan casados entre si");
                return true;
            }
            else 
            {
                Debug.Log("Estan casados pero no esntre si");
                return false;
            }
        }
    }
}
