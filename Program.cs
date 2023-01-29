using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();
            Console.WriteLine("Peces Gordos \n***************************");
            ce.getSeo("CEO");
            
            Console.WriteLine("");
            Console.WriteLine("Plantilla \n***************************");
            ce.getEmpleadosOrdenados();
            Console.WriteLine("");
            Console.WriteLine("Plantilla ordenada \n***************************");
            ce.getEmpleadosOrdenadosSegun();
            
            Console.WriteLine("\nIngrese la empresa (entero 1 o 2)");
            string _Id = Console.ReadLine();
            try
            {
                int _Empresa = int.Parse(_Id);
                ce.getEmpleadosEmpresa(_Empresa);
            }
            catch
            {
                Console.WriteLine("Ha introducido un Id erroneo. Debe ingresar un numero entero");
            }
        }
    }
}
