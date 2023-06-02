using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO.Clases

    }
    .
  
{
    public class Articulos
    { 
        
        public void ArticulosPrecio() 
        {
           
            /*string Art1, Art2, Art3, Art4, Art5;*/
            /*Console.WriteLine("Nombre del primer articulo");
            Art1 = Console.ReadLine();
            Console.WriteLine("Nombre del segundo articulo");
            Art2 = Console.ReadLine();
            Console.WriteLine("Nombre del tercer articulo");
            Art3 = Console.ReadLine();
            Console.WriteLine("Nombre del cuarto articulo");
            Art4 = Console.ReadLine();
            Console.WriteLine("Nombre del quinto articulo");
            Art5 = Console.ReadLine();*/
            Persona datos = new Persona();
            datos.PedirDatos();
           
            double PreArt1, PreArt2, PreArt3, PreArt4, PreArt5, precio, preciofinal;       
            Console.WriteLine("Precio del primer articulo: ");
            PreArt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio del segundo articulo: ");
            PreArt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio del tercer articulo: ");
            PreArt3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio del cuarto articulo: " );
            PreArt4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio del quinto articulo: ");
            PreArt5 = int.Parse(Console.ReadLine());
            precio = PreArt1 + PreArt2 + PreArt3 + PreArt4 + PreArt5;
            Console.WriteLine("El total de los productos es " + precio);
            if (precio >= 5000 && precio < 8000)
            {
                preciofinal = precio - (precio / 10);

                Console.WriteLine("Se te aplicó un 10% de descuento "+preciofinal);
            }
            else if (precio >= 8000 && precio<10000)
            {
                Console.WriteLine("Pago en tres meses intereses");
            }
            else if (precio > 10000)
            {
                int opcion;
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Pago en 6 meses intereses");
                        break;
                    case 2:
                        Console.WriteLine("Pago en 12 meses sin intereses");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No se puede aplicar ningún beneficio o descuento");
            }

            datos.MostrarDatos();
        }
    }
}

    

