using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    private Libro[] libros;

    public Biblioteca(int capacidad) => libros = new Libro[capacidad];

    public void AgregarLibro()
    {
        Console.WriteLine("Ingrese los detalles del libro:");
        Console.Write("Código: ");
        int codigo;

        while (!int.TryParse(Console.ReadLine(), out codigo))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero para el código.");
            Console.Write("Código: ");
        }

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Libro nuevoLibro = new Libro(codigo, titulo, autor);

        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] == null)
            {
                libros[i] = nuevoLibro;
                Console.WriteLine("Libro agregado exitosamente.");
                MostrarInventario();
                return;
            }
        }

        Console.WriteLine("La biblioteca está llena. No se pueden agregar más libros.");
    }

    public void RetirarLibrosNoUtilizados()
    {
        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] != null && !libros[i].Prestado)
            {
                libros[i] = null;
            }
        }

        Console.WriteLine("Libros no utilizados retirados exitosamente.");
        MostrarInventario();
    }

    public void PrestarLibro()
    {
        Console.Write("Ingrese el código del libro que desea prestar: ");
        int codigo;

        while (!int.TryParse(Console.ReadLine(), out codigo))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero para el código.");
            Console.Write("Código: ");
        }

        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] != null && libros[i].Codigo == codigo && !libros[i].Prestado)
            {
                libros[i].Prestado = true;
                Console.WriteLine("Libro prestado exitosamente.");
                MostrarInventario();
                return;
            }
        }

        Console.WriteLine("Libro no encontrado o ya prestado.");
    }

    public void DevolverLibro()
    {
        Console.Write("Ingrese el código del libro que desea devolver: ");
        int codigo;

        while (!int.TryParse(Console.ReadLine(), out codigo))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero para el código.");
            Console.Write("Código: ");
        }

        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] != null && libros[i].Codigo == codigo && libros[i].Prestado)
            {
                libros[i].Prestado = false;
                Console.WriteLine("Libro devuelto exitosamente.");
                MostrarInventario();
                return;
            }
        }

        Console.WriteLine("Libro no encontrado o no prestado.");
    }

    public void MostrarInventario()
    {
        Console.WriteLine("\nInventario de la Biblioteca:");
        foreach (var libro in libros)
        {
            if (libro != null)
            {
                Console.WriteLine($"Código: {libro.Codigo}, Título: {libro.Titulo}, Autor: {libro.Autor}, Prestado: {(libro.Prestado ? "Sí" : "No")}");
            }
        }
    }
}