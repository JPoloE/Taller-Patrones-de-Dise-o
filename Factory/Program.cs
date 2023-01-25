
using Factory;

//Estoy creando una nueva bebida "Vino"
BebidaEmbriagante BebidaVino = Gestor.GestorDeBebidas(Gestor.Vino);

//Estoy usando el metodo de la clase padre
Console.WriteLine(BebidaVino.NivelDeEbriedadPorHora() + "\n");


//Estoy creando una nueva bebida "Vino"
BebidaEmbriagante BebidaTequila = Gestor.GestorDeBebidas(Gestor.Tequila);

//Estoy usando el metodo de la clase padre
Console.WriteLine(BebidaTequila.NivelDeEbriedadPorHora() + "\n");



