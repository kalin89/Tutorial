// See https://aka.ms/new-console-template for more information



using Tutorial;

//Basics.BasicThings();
//For.CiclyFor();
//ArrayClass.BasicArrayUse();
//var cliente1 = new Persona("Carlos");
//cliente1.Nombre = "Carlos";
//cliente1.Apellido = "Arcos";
//cliente1.ImprimeNombre();


var Argo = new Heroe("Argo", TipoHeroe.Raso ,100, 2, 30);
//Forma diferente de inicializar una clase
var Mirana = new Heroe("Mirana", TipoHeroe.distancia,60);

Console.WriteLine($"{Argo.Nombre} Vida: {Argo.Vida} - {Mirana.Nombre} Vida: {Mirana.Vida}");

Console.WriteLine("-------------------");
Console.WriteLine("Argo Ataca a Mirana");
Mirana.RecibirDano(Argo.DanoBasico);
Console.WriteLine($"{Argo.Nombre} Vida: {Argo.Vida} - {Mirana.Nombre} Vida: {Mirana.Vida}");
Console.WriteLine("-------------------");

Console.WriteLine("-------------------");
Console.WriteLine("Mirana Ataca a Argo");
Argo.RecibirDano(Mirana.DanoBasico);
Console.WriteLine($"{Argo.Nombre} Vida: {Argo.Vida} - {Mirana.Nombre} Vida: {Mirana.Vida}");
Console.WriteLine("-------------------");

Console.WriteLine("-------------------");
Console.WriteLine("Argo Ataca a Mirana");
Mirana.RecibirDano(Argo.DanoBasico);
Console.WriteLine($"{Argo.Nombre} Vida: {Argo.Vida} - {Mirana.Nombre} Vida: {Mirana.Vida}");
Console.WriteLine("-------------------");

