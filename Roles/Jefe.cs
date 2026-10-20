using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Empresa.Roles
{
    class Jefe : Empleado
    {
        public Secretario secretario { get; set; }

        public List<Vendedor> Vendedores { get; set; }

        public Jefe(string nombre, string apellido, string dni, string direccion, int añosAntiguedad, string telefono, double salario) : base(nombre, apellido, dni, direccion, añosAntiguedad, telefono, salario)
        {
          this.Vendedores = new List<Vendedor>();
        }

        public void Agregar(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);

        }

        public void Listar()
        {
            foreach (var v in Vendedores)
            {
                Console.WriteLine($"Nombre: {v.Nombre}, Apellido: {v.Apellido}, DNI: {v.DNI}, Dirección: {v.Direccion}, Antigüedad: {v.AñosAntiguedad}, Teléfono: {v.Telefono}, Salario: {v.Salario}");
                
            }


        }
    }
}