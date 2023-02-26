using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono();
            t1.Marca = "samsung";
            t1.Modelo = "s11";
            t1.llamar();

        
        }   

    }
}
