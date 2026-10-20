using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Roles
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public int AñosAntiguedad { get; set; }
        public string Telefono { get; set; }
        public double Salario { get; set; }

        private Empleado Supervisor { get; set; }

        public Empleado(string nombre, string apellido, string dni, string direccion, int añosAntiguedad, string telefono, double salario)
        {
            if (salario <= 0)
            {
                Console.WriteLine("No puede tener un salario 0");
                return;
            }

            if (dni.Length < 9)
            {
                Console.WriteLine("Numero de Caracteres del documento invalido");
                return;
            }

            if (añosAntiguedad <= 0 || añosAntiguedad > 100)
            {
                Console.WriteLine("Años de antigüedad inválidos");
                return;
            }

            if (telefono.ToString().Length < 10)
            {
                Console.WriteLine("telefono invalido");
                return;
            }

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.AñosAntiguedad = añosAntiguedad;
            this.Telefono = telefono;
            this.Salario = salario;

            Console.WriteLine("Empleado registrado con exito");
        }

        /*
         * definimos un constructor dos constructores, uno para crear un empleado sin supervisor 
         * y otro donde se le asigne un supervisor, ya que no todo empleado tiene un supervisor
         */

        public Empleado(string nombre, string apellido, string dni, string direccion, int añosAntiguedad, string telefono, double salario, Empleado supervisor)
        {
            if (salario <= 0)
            {
                Console.WriteLine("No puede tener un salario 0");
            }

            if (dni.Length != 9)
            {
                Console.WriteLine("Numero de Caracteres del documento invalido");
            }

            if (añosAntiguedad <= 0 || añosAntiguedad > 100)
            {
                Console.WriteLine("Años de antigüedad inválidos");
            }

            if (supervisor == null)
            {
                Console.WriteLine("Debe de tener un supervisor al pendiente de usted");

            }


            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Direccion = direccion;
            this.AñosAntiguedad = añosAntiguedad;
            this.Telefono = telefono;
            this.Salario = salario;
            this.Supervisor = supervisor;
        }

        /*
         definimos un metodo para cambiar el supervisor de un empleado por otro
         */
        public void CambiarSupervisor(Empleado supervisor)
        {
            this.Supervisor = supervisor;

            Console.WriteLine($"Su supervisor ahora es {this.Supervisor.Nombre}");
        }

        /*
         definimos un metodo para incrementar y retornar el nuevo salario de un empleado, el cual puede ser un porcentaje decimal o entero
         */

        public double IncrementarSalario(double porcentaje)
        {
            if (porcentaje <= 0)
            {
                Console.WriteLine("Porcentaje invalido");
                return 0.0;
            }

            double porcentajeDecimal = porcentaje / 100;

            double incremento = Salario * (1 + porcentajeDecimal);

            return incremento;

        }

    }
}