using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Roles
{
    class Secretario : Empleado
    {
        private string Despacho { get; set; }

        private int Fax { get; set; }

        public Secretario(string despacho, int fax, string nombre, string apellido, string dni, string direccion, int añosAntiguedad, string telefono, double salario) : base(nombre, apellido, dni, direccion, añosAntiguedad, telefono, salario)
        {

            if (fax.ToString().Length < 9)
            {
                Console.WriteLine("Fax invalido");
                return;
            }
            this.Despacho = despacho;
            this.Fax = fax;

        }
    }
}