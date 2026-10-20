using System;
using System.Collections.Generic;
using System.Text;
using Empresa.Roles;

namespace Empresa.Roles
{
    class Vendedor : Empleado
    {
        private string AreaVentas { get; set; }

        private List<Cliente> Clientes { get; set; }

        private double Porcentaje { get; set; }

        public Vendedor(string area, double porcentaje, string nombre, string apellido, string dni, string direccion, int añosAntiguedad, string telefono, double salario) : base(nombre, apellido, dni, direccion, añosAntiguedad, telefono, salario)
        {
            this.Clientes = new List<Cliente>();

            this.AreaVentas = area;

            this.Porcentaje = porcentaje;
        }
        public void Agregar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void Listar()
        {
            foreach (var c in Clientes)
            {

                Console.WriteLine($"Nombre: {c.nombre}, Apellido: {c.apellido}");
                
            }

        }
    }
}