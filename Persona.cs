namespace Tutorial
{
    public class Persona
    {
        //Un paradigma de programación que utiliza "objetos"
        //para representar datos y métodos.
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido = "") 
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        //Crear un metodo
        //acceso: publico, privado, statico
        //void No regresa nada, int regresar un entero
        // bool regresar un boleano
        // string regresar
        public void ImprimeNombre()
        {
            Console.WriteLine($"Hola mi nombre es {Nombre} {Apellido}");
        }
    }
}
