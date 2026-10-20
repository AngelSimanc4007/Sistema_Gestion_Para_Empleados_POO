using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Roles
{
    class Cliente
    {
        //definimos los campos que tendra nuestra clase cliente
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public string requisitos { get; set; }

        public Cliente(string nombre, string apellido, string direccion, string telefono, string correo, string requisitos)

        {

            if (telefono.Length < 10)
            {
                Console.WriteLine("telefono invalido");
                return;
            }

            if (!correo.Contains("@") || !correo.Contains(".com"))
            {
                Console.WriteLine("correo invalido");
                return;
            }

            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.requisitos = requisitos;
        }

        public Cliente(){ }

        public string InformacionCliente()
        {
            return $"Nombre: {nombre}, Apellido: {apellido}, Direccion: {direccion}, Telefono: {telefono}, Correo: {correo}, Requisitos: {requisitos}";
        }


    }
}