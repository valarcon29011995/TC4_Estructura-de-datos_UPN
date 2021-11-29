using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("1", 1, "Mauricio", "Cubas");
            Paciente paciente2 = new Paciente("2", 2, "Victor", "Alarcon");
            Paciente paciente3 = new Paciente("3", 3, "Manuel", "Arroyo");
            Paciente paciente4 = new Paciente("4", 4, "Miriam", "Castellanos");
            Paciente paciente5 = new Paciente("5", 5, "Pamela", "Arroyo");

            Nodo colaEspera = null;
            ColaDePrioridad lista = new ColaDePrioridad();
            Console.WriteLine("********** Lista de Pacientes **********");
            colaEspera = lista.NuevoNodo(paciente1, paciente1.prioridad);
            colaEspera = lista.push(colaEspera, paciente2, paciente2.prioridad);
            colaEspera = lista.push(colaEspera, paciente3, paciente3.prioridad);
            colaEspera = lista.push(colaEspera, paciente4, paciente4.prioridad);
            colaEspera = lista.push(colaEspera, paciente5, paciente5.prioridad);
            lista.RecorrerCola(colaEspera);

            Console.WriteLine("********** PROCESANDO 2 PACIENTES **********");
            colaEspera = lista.pop(colaEspera);
            colaEspera = lista.pop(colaEspera);
            lista.RecorrerCola(colaEspera);

            Console.WriteLine("********** Ingresando paciente con prioridad 0 **********");
            Paciente paciente0 = new Paciente("6", 0, "Heidi", "Arroyo");
            colaEspera = lista.push(colaEspera, paciente0, paciente0.prioridad);
            lista.RecorrerCola(colaEspera);

            Console.WriteLine("********** PROCESANDO 2 PACIENTES **********");
            colaEspera = lista.pop(colaEspera);
            colaEspera = lista.pop(colaEspera);
            lista.RecorrerCola(colaEspera);

            Console.ReadKey();
        }
    }
}
