using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraG2_2024_1
{
    internal class Cafe : Expendedora
    {
        #region Propiedades
        public override byte Temperatura 
        { 
            get => base.Temperatura;
            set 
            {
                if (40 < value && value < 70)
                    temperatura = value;
                else
                    temperatura = 50;
            } 
        }

        #endregion

        #region Constructores
        public Cafe()
        {
            Saludo();
            Temperatura = 45;
            Console.WriteLine("Temperatura:{0} [°C]", Temperatura);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            Precio = 10;
            MostrarPrecio(codigo);
            
        }

        public Cafe(bool Mantenimiento)
        {
            if (Mantenimiento)
                Console.WriteLine("Entrando en modo mantenimiento");
            else
                Saludo();
        }

        public Cafe(int cantProductos)
        {
            Console.WriteLine("La expendedora contiene {0} productos", cantProductos);
        }
        #endregion

        #region Metodos
        public override string MostrarProducto()
        {
            Console.WriteLine("4C: Americano\n4D: Expresso");
            string codigo = Console.ReadLine();
            return codigo;
        }

        public override void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "4C":
                    Console.WriteLine("Precio: ${0}", Precio+3);
                    break;
                case "4D":
                    Console.WriteLine("Precio: ${1}", Precio+6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto valido");
                    break;
            }
        }
        #endregion
    }
}
