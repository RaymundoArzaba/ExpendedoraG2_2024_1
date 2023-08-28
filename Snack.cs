using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpendedoraG2_2024_1
{
    internal class Snack : Expendedora
    {
        #region Constructor
        public Snack()
        {
            Saludo();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", Marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);

        }
        #endregion
    }
}
