using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    public class Persona
{   public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public void PedirDatos()
    {
        Console.WriteLine("Dame tu nombre: "); 
        this.Nombre = Console.ReadLine();
        Console.WriteLine("Dame tu telefono: ");
        this.Telefono = Console.ReadLine();
        Console.WriteLine("Dame tu correo: ");
        this.Correo = Console.ReadLine();
        Console.Clear();
    }
    public void MostrarDatos()
    {
        Console.WriteLine("\nDatos Ingresados");
        Console.WriteLine("\n" +
            "Tu nombre es: " +  this.Nombre);
        Console.WriteLine($"Tu telefono es: " + this.Telefono);
        Console.WriteLine("Tu correo es: " + this.Correo);
    }
}





