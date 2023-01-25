
using Singleton;

//Alerta creada en la primera instancia de la clase
Console.WriteLine(Singleton.Singleton.Instance.alerta + "\n");

//Modificación a ese atributo "Alerta"
Singleton.Singleton.Instance.alerta = "Esta es la alerta creada por un usuario";

//Impresion por consola del nuevo estado de la clase
Console.WriteLine(Singleton.Singleton.Instance.alerta );


