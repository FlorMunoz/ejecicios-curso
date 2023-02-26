using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1POO
{
    public class Telefono
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public string NumeroTelefonico { get; set; }

        public int CodigoOperador
        {
            get { return  CodigoOperador; }

            set {
                if (CodigoOperador == 1)
                {
                    CodigoOperador = CodigoOperador;
                }
                else if (CodigoOperador == 2)
                {
                    CodigoOperador = CodigoOperador;
                }
                else if (CodigoOperador == 3)
                {
                    CodigoOperador = CodigoOperador;
                }
                else
                {
                    CodigoOperador = 0;
                }
            }
        }
        public Telefono (string Modelo, string Marca)
        { this.Modelo = Modelo; this.Marca = Marca; }

        public Telefono()
        {
        }

        public void llamar ()
        {
            Console.WriteLine("Realizando llamada...");
        }
        public void llamar (string contacto)
        {
            Console.WriteLine("Realizando llamada..." + contacto);
        }
    }
}
