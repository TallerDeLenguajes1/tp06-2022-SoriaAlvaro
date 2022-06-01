using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseeEmpleados;

namespace systemAdmin {
    

    class Program {
        enum cargos {
            Auxiliar, Administrativo, Ingeniero, Especialista, Investigador
        };

        static string IngresarNomApe(){
            Console.WriteLine("Ingrese un nombre o apellido");
            string nom = Console.ReadLine();
            return nom;
        }

        static DateTime ingresarFechaN(){
            Console.WriteLine("Fecha de Nacimiento");
            Console.WriteLine("Dia:");
            int d= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes:");
            int m= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Año:");
            int a= Convert.ToInt32(Console.ReadLine());
            DateTime fech = new DateTime(a,m,d);
            return fech;
        }
        static DateTime ingresarFechaI(){
            Console.WriteLine("Fecha de Ingreso");
            Console.WriteLine("Dia:");
            int d= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes:");
            int m= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Año:");
            int a= Convert.ToInt32(Console.ReadLine());
            DateTime fech = new DateTime(a,m,d);
            return fech;
        }
        static char estadoCivil(){
            System.Console.WriteLine("Estado Civil:");
            System.Console.WriteLine("S: soltero/a\nCasado/a: C");
            char estCivil =Convert.ToChar(Console.ReadLine());
            return estCivil;
        }
        static char sexo(){
            System.Console.WriteLine("Estado Civil:");
            System.Console.WriteLine("M: Masculino\nF: Femenino");
            char sexo =Convert.ToChar(Console.ReadLine());
            return sexo;
        }
        static double sueldo(){
            System.Console.WriteLine("sueldo del empleado");
            double sueld = Convert.ToDouble(Console.ReadLine());
            return sueld;
        }
        static void mostrarEmpleado(Empleado emp){
            Console.WriteLine($"Nombre: {emp.Nombre}\nApellido: {emp.Apellido}\nEstado Covil: {emp.EstCivil}\nSexo: {emp.Genero}\nSueldo: {emp.SueldBasico}");
            Console.WriteLine($" fecha de Nacimiento {emp.FechNacimiento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($" fecha de Ingreso {emp.FechIngreso.ToString("dd/MM/yyyy")}");
        }
        static void Main(string[] args){
            Empleado newEmpleado = new Empleado(
                IngresarNomApe(),
                IngresarNomApe(),
                estadoCivil(),
                sexo(),
                sueldo(),
                ingresarFechaN(),
                ingresarFechaI()
            );
            mostrarEmpleado(newEmpleado);
        }
    }

}