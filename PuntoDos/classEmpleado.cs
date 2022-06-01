using System;
using System.Diagnostics;

namespace claseeEmpleados{

    class Empleado{

      public Empleado (string nom,
                       string ape,
                       char estCiv,
                       char gen,
                       double sueldB,
                       DateTime fechN,
                       DateTime fechI)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.fechNacimiento= fechN;
            this.estCivil = estCiv;
            this.genero = gen;
            this.fechIngreso = fechI;
            this.sueldBasico = sueldB;
        }
        private string nombre;
        private string apellido;
        private DateTime fechNacimiento;

        private char estCivil;
        private char genero;
        private DateTime fechIngreso;
        private double sueldBasico;
        private cargos;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechNacimiento { get => fechNacimiento; set => fechNacimiento = value; }
        public char EstCivil { get => estCivil; set => estCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechIngreso { get => fechIngreso; set => fechIngreso = value; }
        public double SueldBasico { get => sueldBasico; set => sueldBasico = value; }
    }
}