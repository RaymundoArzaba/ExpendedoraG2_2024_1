using System;
using System.Threading;

namespace ExpendedoraG2_2024_1
{
    internal class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantproductos;
        private float precio;

        #endregion

        #region Método

        private void Saludo()
        {
            Console.WriteLine("¡Bienvenido!, elige un producto");
        }

        private void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        private string MostrarProducto()
        {
            string codigo = "";
            Console.WriteLine("3A: Doritos \n3B: Churrumais");
            Console.WriteLine("Ingresa el código del producto:");
            codigo = Console.ReadLine();
            return codigo;
        }

        private void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio - 6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto valido");
                    break;
            }
        }

        #endregion

        #region Constructor

        public Expendedora()
        {
            marca = "AMS";
            precio = 18.0F;
            Saludo();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }

        #endregion

    }
}
