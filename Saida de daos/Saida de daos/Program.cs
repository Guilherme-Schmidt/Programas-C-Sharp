﻿using System;
using System.Globalization;




namespace Saida_de_daos {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4560.9;
            nome = "Maria Silva";
            sexo = 'F';

            Console.WriteLine("A funcionaria "+nome+",sexo "+sexo+",ganha "+salario.ToString("F2",CI)+" e tem "+idade+"anos ");


        }
    }
}
