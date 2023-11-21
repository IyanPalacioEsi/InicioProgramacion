using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familia : MonoBehaviour
{
    //Estas personas derivan de la clase persona (usamos info de esa clase)
    public Persona father;
    public Persona mother;
    public Persona son;

    // Start is called before the first frame update
    void Start()
    {
        //Aqui estaria usando el constructor por defecto para definir al padre
        //father = new Persona(); //Instanciando la nueva persona (inicializando)
        //father.firstName = "Juan Alberto"; //despues de instanciar, podemos inicializar las variables
        //father.lastName = "Martinez";
        father.age = 33;
        father.isMale = true;
        father.isMarried = true;
        //Aqui usariamos el segundo tipo de constructor que hemos creado
        father = new Persona("Juan Alberto", "Martinez");
        //Aqui usariamos el tercer tipo de constructor que hemos creado
        //father = new Persona ()
       
        mother = new Persona();
        mother.firstName = "Alicia";
        mother.lastName = "Fernandez";
        mother.age = 30;
        mother.isMale = false;
        mother.isMarried = true;

        //El padre tiene como esposa a la madre
        father.spouse = mother;

        mother.spouse = father;

        //Compruebo si esas dos personas
        if (father.IsMarriedWith(mother))
        {
            Debug.Log(father.firstName + " y " + mother.firstName + " estan casados.");
        }
        else 
        {
            Debug.Log(father.firstName + " y " + mother.firstName + " no estan casados.");
        }

        son = new Persona();
        son.firstName = "Gabriel";
        son.lastName = "Martinez";
        son.age = 7;
        son.isMale = true;
        son.isMarried = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
