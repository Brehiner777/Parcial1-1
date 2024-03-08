using Biblio;

class Programa
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca(10);

        while (true)
        {
            Console.WriteLine("\nMenú de la Biblioteca:");
            Console.WriteLine("1. Agregar un nuevo libro");
            Console.WriteLine("2. Retirar libros no utilizados");
            Console.WriteLine("3. Prestar un libro");
            Console.WriteLine("4. Devolver un libro");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción inválida. Por favor, inténtelo de nuevo.");
                Console.Write("Seleccione una opción: ");
            }

            switch (opcion)
            {
                case 1:
                    biblioteca.AgregarLibro();
                    break;
                case 2:
                    biblioteca.RetirarLibrosNoUtilizados();
                    break;
                case 3:
                    biblioteca.PrestarLibro();
                    break;
                case 4:
                    biblioteca.DevolverLibro();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
            }
        }
    }
}