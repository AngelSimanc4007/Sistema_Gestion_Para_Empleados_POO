using Empresa.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("=============GESTIONAMIENTO muack INVENTARIO DE LA EMPRESA MAPPA============");

            Console.WriteLine("Desea iniciar el proceso de Gestion? (Si/No)");

            string respuesta = Console.ReadLine();

            while (respuesta == "si" || respuesta == "Si")
            {
                Console.WriteLine("Cual es su rol en la empresa?");
                string rol = Console.ReadLine();

                switch (rol)
                {
                    case "Empleado":

                        Console.WriteLine("Ingrese los datos del empleado");

                        Console.WriteLine("Digite su nombre");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Digite su apellido");
                        string apellido = Console.ReadLine();

                        Console.WriteLine("Digite su DNI");
                        string dni = Console.ReadLine();

                        Console.WriteLine("Digite su direccion");
                        string direccion = Console.ReadLine();

                        Console.WriteLine("Digite su edad");
                        int edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su telefono");
                        string telefono = Console.ReadLine();

                        Console.WriteLine("Digite su salario");
                        double salario = double.Parse(Console.ReadLine());


                        Empleado empleado = new Empleado(nombre, apellido, dni, direccion, edad, telefono, salario);

                        Console.WriteLine("Desea ingresar otro empleado?");

                        string miRespuesta = Console.ReadLine();

                        if (miRespuesta == "si" || miRespuesta == "Si")
                        {

                            Console.WriteLine("Ingrese los datos del siguiente empleado");

                            Console.WriteLine("Digite su nombre");
                            string nombre2 = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellido2 = Console.ReadLine();

                            Console.WriteLine("Digite su DNI");
                            string dni2 = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccion2 = Console.ReadLine();

                            Console.WriteLine("Digite su edad");
                            int edad2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su telefono");
                            string telefono2 = Console.ReadLine();

                            Console.WriteLine("Digite su salario");
                            double salario2 = double.Parse(Console.ReadLine());

                            Empleado empleado2 = new Empleado(nombre2, apellido2, dni2, direccion2, edad2, telefono2, salario2);

                        }
                        break;

                    case "Secretario":

                        Console.WriteLine("Ingrese los datos de un Secretario");

                        Console.WriteLine("Digite su nombre");
                        string nombresecretario = Console.ReadLine();

                        Console.WriteLine("Digite su apellido");
                        string apellidosecretario = Console.ReadLine();

                        Console.WriteLine("Digite su direccion");
                        string direccionsecretario = Console.ReadLine();

                        Console.WriteLine("Digite su telefono");
                        string telefonosecretario = Console.ReadLine();

                        Console.WriteLine("Digite su dni");
                        string dnisecretario = Console.ReadLine();

                        Console.WriteLine("Digite sus años de antiguedad");
                        int añosAntiguedadsecretario = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su salario");
                        double Salariosecretario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su fax");
                        int faxsecretario = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su despacho");
                        string despachosecretario = Console.ReadLine();

                        Secretario secretario1 = new Secretario(despachosecretario, faxsecretario,nombresecretario, apellidosecretario, dnisecretario, direccionsecretario, añosAntiguedadsecretario, telefonosecretario, Salariosecretario);

                        break;

                    case "Vendedor":

                        Console.WriteLine("Cuantos clientes desea antender hoy?");
                        int opcion = int.Parse(Console.ReadLine());

                        if (opcion == 1)
                        {
                            Console.WriteLine("Ingrese los datos del Vendedor");

                            Console.WriteLine("Digite su nombre");
                            string nombreVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su dni");
                            string dniVendedor = Console.ReadLine();

                            Console.WriteLine("Digite sus años de antiguedad");
                            int añosAntiguedad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su salario");
                            double SalarioVendedor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su area");
                            string area = Console.ReadLine();

                            Console.WriteLine("Digite su porcentaje");
                            int porcentaje = int.Parse(Console.ReadLine());

                            Vendedor vendedorcito = new Vendedor(area, porcentaje, nombreVendedor, apellidoVendedor, dniVendedor, direccionVendedor, añosAntiguedad, telefonoVendedor, SalarioVendedor);

                            Console.WriteLine("==================================================");

                            Console.WriteLine("Ingrese los datos del cliente numero 1");

                            Console.WriteLine("Digite el nombre");
                            string nombreCliente = Console.ReadLine();

                            Console.WriteLine("Digite el apellido");
                            string apellidoCliente = Console.ReadLine();

                            Console.WriteLine("Digite la direccion");
                            string direccionCliente = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoCliente = Console.ReadLine();

                            Console.WriteLine("Digite su correo");
                            string correoCliente = Console.ReadLine();

                            Console.WriteLine("Digite sus requisitos");
                            string requisito = Console.ReadLine();

                            Cliente cliente = new Cliente(nombreCliente, apellidoCliente, direccionCliente, telefonoCliente, correoCliente, requisito);

                            vendedorcito.Agregar(cliente);

                            vendedorcito.Listar();


                        }
                        else if (opcion == 2)
                        {

                            Console.WriteLine("Ingrese los datos del Vendedor");

                            Console.WriteLine("Digite su nombre");
                            string nombreVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su dni");
                            string dniVendedor = Console.ReadLine();

                            Console.WriteLine("Digite sus años de antiguedad");
                            int añosAntiguedad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su salario");
                            double SalarioVendedor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su area");
                            string area = Console.ReadLine();

                            Console.WriteLine("Digite su porcentaje");
                            int porcentaje = int.Parse(Console.ReadLine());

                            Vendedor vendedorzote = new Vendedor(area, porcentaje, nombreVendedor, apellidoVendedor, dniVendedor, direccionVendedor, añosAntiguedad, telefonoVendedor, SalarioVendedor);

                            Console.WriteLine("==================================================");                

                            Console.WriteLine("Ingrese los datos del primer cliente");

                            Console.WriteLine("Digite su nombre");
                            string nombreCliente = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoCliente = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionCliente = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoCliente = Console.ReadLine();

                            Console.WriteLine("Digite su correo");
                            string correoCliente = Console.ReadLine();

                            Console.WriteLine("Digite sus requisitos");
                            string requisito = Console.ReadLine();

                            Console.WriteLine("==================================================");

                            Console.WriteLine("Ingrese los datos del segundo cliente");

                            Console.WriteLine("Digite su nombre");
                            string nombreCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su correo");
                            string correoCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite sus requisitos");
                            string requisito2 = Console.ReadLine();


                            Cliente cliente = new Cliente(nombreCliente, apellidoCliente, direccionCliente, telefonoCliente, correoCliente, requisito);
                            Cliente cliente2 = new Cliente(nombreCliente2, apellidoCliente2, direccionCliente2, telefonoCliente2, correoCliente2, requisito2);

                            vendedorzote.Agregar(cliente);
                            vendedorzote.Agregar(cliente2);

                            vendedorzote.Listar();

                        }
                        else if (opcion == 3)
                        {
                            Console.WriteLine("Ingrese los datos del Vendedor");

                            Console.WriteLine("Digite su nombre");
                            string nombreVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoVendedor = Console.ReadLine();

                            Console.WriteLine("Digite su dni");
                            string dniVendedor = Console.ReadLine();

                            Console.WriteLine("Digite sus años de antiguedad");
                            int añosAntiguedad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su salario");
                            double SalarioVendedor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite su area");
                            string area = Console.ReadLine();

                            Console.WriteLine("Digite su porcentaje");
                            int porcentaje = int.Parse(Console.ReadLine());

                            Vendedor vendedor1 = new Vendedor(area, porcentaje, nombreVendedor, apellidoVendedor, dniVendedor, direccionVendedor, añosAntiguedad, telefonoVendedor, SalarioVendedor);

                            Console.WriteLine("==================================================");

                            Console.WriteLine("Ingrese los datos del primer cliente");

                            Console.WriteLine("Digite su nombre");
                            string nombreCliente = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoCliente = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionCliente = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoCliente = Console.ReadLine();

                            Console.WriteLine("Digite su correo");
                            string correoCliente = Console.ReadLine();

                            Console.WriteLine("Digite sus requisitos");
                            string requisito = Console.ReadLine();

                            Console.WriteLine("==================================================");

                            Console.WriteLine("Ingrese los datos del segundo cliente");

                            Console.WriteLine("Digite su nombre");
                            string nombreCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite su correo");
                            string correoCliente2 = Console.ReadLine();

                            Console.WriteLine("Digite sus requisitos");
                            string requisito2 = Console.ReadLine();

                            Console.WriteLine("==================================================");

                            Console.WriteLine("Ingrese los datos del tercer cliente");

                            Console.WriteLine("Digite su nombre");
                            string nombreCliente3 = Console.ReadLine();

                            Console.WriteLine("Digite su apellido");
                            string apellidoCliente3 = Console.ReadLine();

                            Console.WriteLine("Digite su direccion");
                            string direccionCliente3 = Console.ReadLine();

                            Console.WriteLine("Digite su telefono");
                            string telefonoCliente3 = Console.ReadLine();

                            Console.WriteLine("Digite su correo");
                            string correoCliente3 = Console.ReadLine();

                            Console.WriteLine("Digite sus requisitos");
                            string requisito3 = Console.ReadLine();


                            Cliente cliente = new Cliente(nombreCliente, apellidoCliente, direccionCliente, telefonoCliente, correoCliente, requisito);
                            Cliente cliente2 = new Cliente(nombreCliente2, apellidoCliente2, direccionCliente2, telefonoCliente2, correoCliente2, requisito2);
                            Cliente cliente3 = new Cliente(nombreCliente3, apellidoCliente3, direccionCliente3, telefonoCliente3, correoCliente3, requisito3);

                            vendedor1.Agregar(cliente);
                            vendedor1.Agregar(cliente2);
                            vendedor1.Agregar(cliente3);

                            vendedor1.Listar();

                        }
                        else
                        {
                            Console.WriteLine("No se presentaron mas clientes");
                        }

                        break;

                    case "Jefe":

                        Console.WriteLine("Digite sus datos, Jefe");

                        Console.WriteLine("Digite su nombre, Jefe");
                        string nombreJefe = Console.ReadLine();

                        Console.WriteLine("Digite su apellido, Jefe");
                        string apellidoJefe = Console.ReadLine();

                        Console.WriteLine("Digite su dni, Jefe");
                        string dniJefe = Console.ReadLine();

                        Console.WriteLine("Digite su direccion, Jefe");
                        string direccionJefe = Console.ReadLine();

                        Console.WriteLine("Digite sus años de antiguedad, Jefe");
                        int añosAntiguedadJefe = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su telefono, Jefe");
                        string telefonoJefe = Console.ReadLine();

                        Console.WriteLine("Digite su salario, Jefe");
                        double salarioJefe = double.Parse(Console.ReadLine());

                        Jefe jefe = new Jefe(nombreJefe, apellidoJefe, dniJefe, direccionJefe, añosAntiguedadJefe, telefonoJefe, salarioJefe);

                        jefe.Vendedores = new List<Vendedor>();

                        Console.WriteLine("==================================================");

                        Console.WriteLine("Ingrese los datos de su secretario");

                        Console.WriteLine("Digite su nombre");
                        string nombreS = Console.ReadLine();

                        Console.WriteLine("Digite su apellido");
                        string apellidoS = Console.ReadLine();

                        Console.WriteLine("Digite su direccion");
                        string direccionS= Console.ReadLine();

                        Console.WriteLine("Digite su telefono");
                        string telefonoS = Console.ReadLine();

                        Console.WriteLine("Digite su dni");
                        string dniS = Console.ReadLine();

                        Console.WriteLine("Digite sus años de antiguedad");
                        int añosS = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su salario");
                        double SalarioS= double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su fax");
                        int faxS = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su despacho");
                        string despachoS = Console.ReadLine();

                        Secretario secretario = new Secretario(despachoS, faxS, nombreS, apellidoS, dniS, direccionS, añosS, telefonoS, SalarioS);

                        jefe.secretario = secretario;

                        Console.WriteLine("==================================================");

                        Console.WriteLine("Ingrese los datos del Vendedor");

                        Console.WriteLine("Digite su nombre");
                        string nombrev = Console.ReadLine();

                        Console.WriteLine("Digite su apellido");
                        string apellidov = Console.ReadLine();

                        Console.WriteLine("Digite su direccion");
                        string direccionv = Console.ReadLine();

                        Console.WriteLine("Digite su telefono");
                        string telefonov = Console.ReadLine();

                        Console.WriteLine("Digite su dni");
                        string dniv = Console.ReadLine();

                        Console.WriteLine("Digite sus años de antiguedad");
                        int añov = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su salario");
                        double salariov = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su area");
                        string areav = Console.ReadLine();

                        Console.WriteLine("Digite su porcentaje");
                        int porcentajev = int.Parse(Console.ReadLine());

                        Console.WriteLine("==================================================");

                        Console.WriteLine("Ingrese los datos del segundo Vendedor");

                        Console.WriteLine("Digite su nombre");
                        string nombrev2 = Console.ReadLine();

                        Console.WriteLine("Digite su apellido");
                        string apellidov2 = Console.ReadLine();

                        Console.WriteLine("Digite su direccion");
                        string direccionv2 = Console.ReadLine();

                        Console.WriteLine("Digite su telefono");
                        string telefonov2 = Console.ReadLine();

                        Console.WriteLine("Digite su dni");
                        string dniv2 = Console.ReadLine();

                        Console.WriteLine("Digite sus años de antiguedad");
                        int añov2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su salario");
                        double salariov2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su area");
                        string areav2 = Console.ReadLine();

                        Console.WriteLine("Digite su porcentaje");
                        int porcentajev2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("==================================================");

                        Console.WriteLine("Ingrese los datos del tercer Vendedor");

                        Console.WriteLine("Digite su nombre");
                        string nombrev3 = Console.ReadLine();

                        Console.WriteLine("Digite su apellido");
                        string apellidov3 = Console.ReadLine();

                        Console.WriteLine("Digite su direccion");
                        string direccionv3 = Console.ReadLine();

                        Console.WriteLine("Digite su telefono");
                        string telefonov3 = Console.ReadLine();

                        Console.WriteLine("Digite su dni");
                        string dniv3 = Console.ReadLine();

                        Console.WriteLine("Digite sus años de antiguedad");
                        int añov3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su salario");
                        double salariov3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite su area");
                        string areav3 = Console.ReadLine();

                        Console.WriteLine("Digite su porcentaje");
                        int porcentajev3 = int.Parse(Console.ReadLine());

                        Vendedor vendedor = new Vendedor(areav, porcentajev, nombrev, apellidov, dniv, direccionv, añov, telefonov, salariov);
                        Vendedor vendedor2 = new Vendedor(areav2, porcentajev2, nombrev2, apellidov2, dniv2, direccionv2, añov2, telefonov2, salariov2);
                        Vendedor vendedor3  = new Vendedor(areav3, porcentajev3, nombrev3, apellidov3, dniv3, direccionv3, añov3, telefonov3, salariov3);

                        jefe.Agregar(vendedor);
                        jefe.Agregar(vendedor2);
                        jefe.Agregar(vendedor3);

                        jefe.Listar();
                        break;

                    default:
                        Console.WriteLine("Este rol no existe, intentelo otra vez");
                        break;

                }

                Console.WriteLine("Desea hacer otra cosa? (Si/No)");

                respuesta = Console.ReadLine();

            }

            Console.WriteLine("Gracias por su colaboracion");

        }


    }
}